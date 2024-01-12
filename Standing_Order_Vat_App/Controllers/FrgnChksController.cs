using AspNetCoreHero.ToastNotification.Abstractions;
using GbRegister.Core.ViewModel;
//using Microsoft.AspNetCore.Mvc;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.Common.Helper;
using Standing_Order_Vat_App.DAL.GB_Register;
using Standing_Order_Vat_App.DAL.SKNANB_LIVE;
using Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB;
using System.Web.Helpers;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using DocumentFormat.OpenXml.Office2016.Excel;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Standing_Order_Vat_App.Common.GeneralResult;
using DocumentFormat.OpenXml.Drawing.Charts;
using VATCustomServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using static Standing_Order_Vat_App.MvcHelper.Enumration;
using Standing_Order_Vat_App.Common.Services;

namespace Standing_Order_Vat_App.Controllers
{
    // [Authorize(Roles = ApplicationAccess.Foreign_Check.GetEnumDisplayName())]
    public class FrgnChksController : Controller
    {
        private readonly IFrgnChks _frgnchks;
        private readonly IUserRole userRoleService;
        private readonly General_Banking_RegistersContext _context;
        private readonly SKNANBLIVEContext _sKNANBLIVEContext;
        private readonly INotyfService _notyf;
        private readonly IAccountRepo accountRepo;


        public FrgnChksController(IFrgnChks frgnChks, IUserRole userRoleService, General_Banking_RegistersContext context, SKNANBLIVEContext sKNANBLIVEContext, INotyfService notyf, IAccountRepo accountRepo)
        {
            _frgnchks = frgnChks;
            this.userRoleService = userRoleService;
            _context = context;
            _sKNANBLIVEContext = sKNANBLIVEContext;
            _notyf = notyf;
            this.accountRepo = accountRepo;
        }

        public IActionResult Index()
        {
            accountRepo.SetUserinfoInSession();
            userRoleService.GetUserRole(User.Identity.Name);

            if (!accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Foreign_Check.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            var rec = _frgnchks.GetBanks();
            ViewBag.BankName = rec;
            return View();
        }

        [HttpGet]
        public IActionResult AddFrgnCheckAsync()
        {
            accountRepo.SetUserinfoInSession();
            userRoleService.GetUserRole(User.Identity.Name);

            if (!accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Foreign_Check.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            ForeignCheckVm vm = new ForeignCheckVm();
            vm.BanksList = _frgnchks.GetBanks();
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> AddFrgnCheckAsync(string actionbtn, ForeignCheckVm foreignChecksDetail)
        {
            userRoleService.GetUserRole(User.Identity.Name);

            if (!accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Foreign_Check.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            try
            {
                foreignChecksDetail.BanksList = _frgnchks.GetBanks();
                if (actionbtn == "batchHeader")
                {
                    //foreignChecksDetail.BatchId = 555;

                    FrgnCheckVm vm = new FrgnCheckVm();
                    vm.dtRecvd = (DateTime)foreignChecksDetail.DateRecived;
                    vm.dtProcessed = DateTime.Now;
                    vm.empId = Convert.ToInt32(accountRepo.GetEmpId());
                    vm.batchStat = 1;
                    vm.branch = accountRepo.GetBranchID();
                    vm.bankId = foreignChecksDetail.BankId.ToString();
                    var response = await _frgnchks.SaveFrgnBatch(vm);
                    if (response > 0)
                    {
                        foreignChecksDetail.BatchId = response;
                        //foreignChecksDetail.TotalAmount = Convert.ToDecimal(await _frgnchks.GetCheckTotal(foreignChecksDetail.BatchId));
                        //var list = await _frgnchks.GetFrgnChksByBatchID(foreignChecksDetail.BatchId);
                        //if (list.Successful)
                        //{
                        //    List<FrgnCheckListVm> v = DataTableToModelConvert.CreateListFromTable<FrgnCheckListVm>(list.Value);
                        //    foreignChecksDetail.checksList = v;
                        //}
                        ModelState.Clear();
                        _notyf.Success("Header Saved successfully. Add Checked.");
                        return View(foreignChecksDetail);
                    }
                    _notyf.Warning("Something went wrong!");
                }
                if (actionbtn == "saveCheck")
                {
                    if (foreignChecksDetail != null)
                    {
                        //foreignChecksDetail.BatchId = 555;
                        var response = await _frgnchks.AddFrgnCheack(foreignChecksDetail);
                        if (response.Successful)
                        {
                            foreignChecksDetail.CheckNumber = 0;
                            foreignChecksDetail.PayerAcctNumber = 0;
                            foreignChecksDetail.PayerAcctName = "";
                            foreignChecksDetail.DepositAcctName = "";
                            foreignChecksDetail.DepositAcctNumber = 0;
                            foreignChecksDetail.CheckAmount = 0;
                            ModelState.Clear();
                            _notyf.Success("Check Saved successfully.");
                            foreignChecksDetail.TotalAmount = Convert.ToDecimal(response.Value);
                            foreignChecksDetail.TotalAmount = Math.Round((decimal)foreignChecksDetail.TotalAmount, 2);
                            var list = await _frgnchks.GetFrgnChksByBatchID(foreignChecksDetail.BatchId);
                            if (list.Successful)
                            {
                                List<FrgnCheckListVm> v = DataTableToModelConvert.CreateListFromTable<FrgnCheckListVm>(list.Value);
                                foreignChecksDetail.checksList = v;
                                return View(foreignChecksDetail);

                            }
                        }
                        _notyf.Warning("Something went wrong!");
                    }
                }

                foreignChecksDetail.BatchId = 0;
                foreignChecksDetail.CheckNumber = 0;
                foreignChecksDetail.PayerAcctNumber = 0;
                foreignChecksDetail.PayerAcctName = "";
                foreignChecksDetail.DepositAcctName = "";
                foreignChecksDetail.DepositAcctNumber = 0;
            }
            catch (Exception ex)
            {

                _notyf.Error("Server error!");
            }
            return View(foreignChecksDetail);

        }
        //[HttpPost]
        //public async Task<IGeneralResult<PartialViewResult>> ShowBatchCheckList(int BatchId)
        //{
        //    IGeneralResult<PartialViewResult> res = new GeneralResult<PartialViewResult>();
        //    if(BatchId > 0)
        //    {
        //        var list = await _frgnchks.GetFrgnChksByBatchID(BatchId);
        //        if (list.Successful)
        //        {
        //            ForeignCheckVm vm = new ForeignCheckVm();
        //            List<FrgnCheckListVm> v = DataTableToModelConvert.CreateListFromTable<FrgnCheckListVm>(list.Value);
        //            vm.checksList = v;
        //            var viw = PartialView("_BatchChecksListOnUpdate",vm);
        //            res.Successful = true;
        //            res.Value = viw;
        //        }
        //    }
        //    else
        //    {
        //        res.Message = "Invalid batch";
        //    }
        //    return res;
        //}

        [HttpPost]
        public async Task<IActionResult> ShowBatchCheckList(int BatchId,string type)
        {
            var list = await _frgnchks.GetFrgnChksByBatchID(BatchId);
            if (list.Successful)
            {
                ForeignCheckVm vm = new ForeignCheckVm();
                List<FrgnCheckListVm> v = DataTableToModelConvert.CreateListFromTable<FrgnCheckListVm>(list.Value);
                vm.checksList = v;
                vm.BatchId = BatchId;
                if(type == "AddFrgn")
                {
                    return PartialView("_FrgnCheckList", v);
                }
                else
                {
                    return PartialView("_BatchChecksListOnUpdate", vm);
                }
            }
            return View();
        }

        [HttpGet]
        public JsonResult FrgncheckList()
        {
            var res = _frgnchks.GetAllforeign();
            return Json(res);
        }

        [HttpGet]
        public async Task<IActionResult> ViewAsync()
        {
            FrgnViewCheckVm res = new FrgnViewCheckVm();
            accountRepo.SetUserinfoInSession();
            userRoleService.GetUserRole(User.Identity.Name);

            if (!accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Foreign_Check.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            //FrgnViewCheckVm res = new FrgnViewCheckVm();
            res.entryStatusVM = new List<ForeignCheckStatusVM>();
            //res.bankList = new List<BankListVm>();
            res.entryStatusVM = await _frgnchks.GetEntryStatus();
            res.bankList = await _sKNANBLIVEContext.Banks.Select(s => new BankListVm()
            {
                BankId = s.BankId,
                BankName = s.Name
            }).ToListAsync();
            //if (res.Status == 1)
            //{
            //    res.FrgncheckListIncompletes = ListIncomplete(res);
            //}
            //else
            //{
            //    res.FrgnCheckListRecVms = ListComplete(res);
            //}
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> ViewAsync(FrgnViewCheckVm res)
        {
            accountRepo.SetUserinfoInSession();
            userRoleService.GetUserRole(User.Identity.Name);

            if (!accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Foreign_Check.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            //FrgnViewCheckVm res = new FrgnViewCheckVm();
            //res.entryStatusVM = new List<ForeignCheckStatusVM>();
            //res.bankList = new List<BankListVm>();
            res.entryStatusVM = await _frgnchks.GetEntryStatus();
            res.bankList = await _sKNANBLIVEContext.Banks.Select(s => new BankListVm()
            {
                BankId = s.BankId,
                BankName = s.Name
            }).ToListAsync();
            if (res.Status == 1)
            {
                res.FrgncheckListIncompletes = ListIncomplete(res);
            }
            else
            {
                res.FrgnCheckListRecVms = ListComplete(res);
            }
            return View(res);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFrgn()
        {
            accountRepo.SetUserinfoInSession();
            userRoleService.GetUserRole(User.Identity.Name);

            if (!accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Foreign_Check.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            FrgnViewCheckVm res = new FrgnViewCheckVm();
            res.entryStatusVM = new List<ForeignCheckStatusVM>();
            res.bankList = new List<BankListVm>();

            res.entryStatusVM = await _frgnchks.GetEntryStatus();
            res.bankList = await _sKNANBLIVEContext.Banks.Select(s => new BankListVm()
            {
                BankId = s.BankId,
                BankName = s.Name
            }).ToListAsync();


            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFrgn(FrgnViewCheckVm res)
        {
            userRoleService.GetUserRole(User.Identity.Name);

            if (!accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Foreign_Check.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            // FrgnViewCheckVm res = new FrgnViewCheckVm();
            res.entryStatusVM = new List<ForeignCheckStatusVM>();
            res.bankList = new List<BankListVm>();

            res.entryStatusVM = await _frgnchks.GetEntryStatus();
            res.bankList = await _sKNANBLIVEContext.Banks.Select(s => new BankListVm()
            {
                BankId = s.BankId,
                BankName = s.Name
            }).ToListAsync();

            if (res.Status == 1)
            {
                res.FrgncheckListIncompletes = ListIncomplete(res);
            }
            else
            {
                res.FrgnCheckListRecVms = ListComplete(res);
            }
            return View(res);
        }
        [HttpPost]
        public IGeneralResult<string> UpdateDatePayment(UpdateDatePaymentVm vm)
        {
           var res = _frgnchks.UpdateDatePaymentRequest(vm);
            return res;
        }
        [HttpPost]
        public async Task<IGeneralResult<string>> UpdateFrgnCheck(ForeignCheckvmm foreignCheck)
        {
            IGeneralResult<string> result = new GeneralResult<string>();
            try
            {
                if (foreignCheck == null)
                {
                    result.Message = "Something Went Wrong";
                }
                else
                {
                    var response = await _frgnchks.UpdateFrgn(foreignCheck);
                    return response;
                }
            }
            catch (Exception ex)
            {
                result.Message = "Server error: " + ex.Message;
            }
            return result;
        }

        [HttpPost]
        public async Task<IGeneralResult<string>> DeletefrgnCheck(int batchid)
        {
            userRoleService.GetUserRole(User.Identity.Name);

            IGeneralResult<string> res = new GeneralResult<string>();
            if (!accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Foreign_Check.GetEnumDisplayName()))
            {
                res.Message = "Access Denied";
                return res;

            }
            if (batchid > 0)
            {
                var result = await _frgnchks.DeleteFrgnChksBatch(batchid);
                return result;
            }
            else
            {
                res.Message = "Batch Not Found!";
            }
            return res;
        }
        public JsonResult Status()
        {
            var status = _context.EntryStatuses.ToList();
            return Json(status);
        }

        public JsonResult Banks()
        {
            var banks = _sKNANBLIVEContext.Banks.ToList();
            return Json(banks);
        }

        private List<frgncheckListIncomplete> ListIncomplete(FrgnViewCheckVm res)
        {

            List<frgncheckListIncomplete> result1 = new List<frgncheckListIncomplete>();
            string branch = accountRepo.GetBranchID();
            switch (res.Options)
            {
                case 1:
                    var a = _frgnchks.record(res.Status, branch, res.Banks, res.From, res.To);
                    if (a.Result.Value != null)
                    {

                        result1 = DataTableToModelConvert.ConvertToList<frgncheckListIncomplete>(a.Result.Value);
                    }

                    break;
                case 2:
                    var b = _frgnchks.record1(res.Status, branch, res.Banks, res.From, res.To);
                    if (b.Result.Value != null)
                    {
                        if (res.Status == 1)
                        {
                            result1 = DataTableToModelConvert.ConvertToList<frgncheckListIncomplete>(b.Result.Value);
                        }


                    }
                    break;
                case 3:
                    var c = _frgnchks.record2(res.Status, branch, res.Banks, res.From, res.To);
                    if (c.Result.Value != null)
                    {
                        if (res.Status == 1)
                        {
                            result1 = DataTableToModelConvert.ConvertToList<frgncheckListIncomplete>(c.Result.Value);
                        }

                    }
                    break;
            }
            res.FrgncheckListIncompletes = result1;
            return result1;
        }

        private List<FrgnCheckListRecVm> ListComplete(FrgnViewCheckVm res)
        {
            List<FrgnCheckListRecVm> result = new List<FrgnCheckListRecVm>();
            string branch = accountRepo.GetBranchID();
            switch (res.Options)
            {
                case 1:
                    var a = _frgnchks.record(res.Status, branch, res.Banks, res.From, res.To);
                    if (a.Result.Value != null)
                    {
                        result = DataTableToModelConvert.ConvertToList<FrgnCheckListRecVm>(a.Result.Value);
                    }
                    break;
                case 2:
                    var b = _frgnchks.record1(res.Status, branch, res.Banks, res.From, res.To);
                    if (b.Result.Value != null)
                    {
                        if (res.Status == 1)
                        {
                            result = DataTableToModelConvert.ConvertToList<FrgnCheckListRecVm>(b.Result.Value);
                        }

                    }
                    break;
                case 3:
                    var c = _frgnchks.record2(res.Status, branch, res.Banks, res.From, res.To);
                    if (c.Result.Value != null)
                    {
                        result = DataTableToModelConvert.ConvertToList<FrgnCheckListRecVm>(c.Result.Value);
                    }

                    break;
            }
            res.FrgnCheckListRecVms = result;
            return result;

        }
    }

}

