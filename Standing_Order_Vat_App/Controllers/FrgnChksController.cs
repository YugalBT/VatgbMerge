using AspNetCoreHero.ToastNotification.Abstractions;
using GbRegister.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.Common.Helper;
using Standing_Order_Vat_App.DAL.GB_Register;
using Standing_Order_Vat_App.DAL.SKNANB_LIVE;
using Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB;
using System.Web.Helpers;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using Standing_Order_Vat_App.Common.GeneralResult;

namespace Standing_Order_Vat_App.Controllers
{
    public class FrgnChksController : Controller
    {
        private readonly IFrgnChks _frgnchks;
        private readonly General_Banking_RegistersContext _context;
        private readonly SKNANBLIVEContext _sKNANBLIVEContext;
        private readonly INotyfService _notyf;

        public FrgnChksController(IFrgnChks frgnChks, General_Banking_RegistersContext context, SKNANBLIVEContext sKNANBLIVEContext, INotyfService notyf)
        {
            _frgnchks = frgnChks;
            _context = context;
            _sKNANBLIVEContext = sKNANBLIVEContext;
            _notyf = notyf;
        }

        public IActionResult Index()
        {
            var rec = _frgnchks.GetBanks();
            ViewBag.BankName = rec;
            return View();
        }



        [HttpGet]
        public IActionResult AddFrgnCheckAsync()
        {
            ForeignCheckVm vm = new ForeignCheckVm();
            vm.BanksList = _frgnchks.GetBanks();
            return View(vm);
        }

        //[HttpPost]
        //public async Task<IGeneralResult<int>> SaveFrgnBatchHeader(FrgnCheckVm frgnCheckVm)
        //{
        //    IGeneralResult<int> res = new GeneralResult<int>();
        //    try
        //    {
        //        frgnCheckVm.dtProcessed = DateTime.Now;
        //        frgnCheckVm.empId = 29;
        //        frgnCheckVm.batchStat = 1;
        //        frgnCheckVm.branch = "00";
        //        var response = await _frgnchks.SaveFrgnBatch(frgnCheckVm);
        //        if (response.BatchId > 0)
        //        {
        //            res.Successful = true;
        //            res.Message = "Header Saved successfully. Add Checked.";
        //            res.Value = (int)response.BatchId;
        //            return res;
        //        }
        //        res.Message = "Something went wrong. Please try again!";
        //    }
        //    catch (Exception ex)
        //    {
        //        res.Message = "Server error!";
        //    }
        //    return res;
        //}


        //[HttpPost]
        //public async Task<IActionResult> SaveFrgnBatchHeader(ForeignCheckVm frgnCheckVm)
        //{
        //    try
        //    {
        //        FrgnCheckVm vm = new FrgnCheckVm();
        //        vm.dtRecvd = (DateTime)frgnCheckVm.DateRecived;
        //        vm.dtProcessed = DateTime.Now;
        //        vm.empId = 29;
        //        vm.batchStat = 1;
        //        vm.branch = "00";
        //        vm.bankId = frgnCheckVm.BankId.ToString();
        //        frgnCheckVm.BatchId = 24;
        //        var response = await _frgnchks.SaveFrgnBatch(vm);
        //        if (response > 0)
        //        {
        //            string Message = "Header Saved successfully. Add Checked.";
        //            frgnCheckVm.BanksList = _frgnchks.GetBanks();
        //            frgnCheckVm.TotalAmount = Convert.ToDecimal(await _frgnchks.GetCheckTotal(frgnCheckVm.BatchId));
        //            var list = await _frgnchks.GetFrgnChksByBatchID(frgnCheckVm.BatchId);
        //            if (list.Successful)
        //            {
        //                List<FrgnCheckListVm> v = DataTableToModelConvert.CreateListFromTable<FrgnCheckListVm>(list.Value);
        //                frgnCheckVm.checksList = v;
        //            }
        //            return View("AddFrgnCheck", frgnCheckVm);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
                
        //    }
        //    return RedirectToAction("AddFrgnCheck");
        //}


        [HttpPost]
        public async Task<IActionResult> AddFrgnCheckAsync(string actionbtn, ForeignCheckVm foreignChecksDetail)
        {

            try
            {
                foreignChecksDetail.BanksList = _frgnchks.GetBanks();
                if (actionbtn == "batchHeader")
                {
                    foreignChecksDetail.BatchId = 24;

                    FrgnCheckVm vm = new FrgnCheckVm();
                    vm.dtRecvd = (DateTime)foreignChecksDetail.DateRecived;
                    vm.dtProcessed = DateTime.Now;
                    vm.empId = 29;
                    vm.batchStat = 1;
                    vm.branch = "00";
                    vm.bankId = foreignChecksDetail.BankId.ToString();
                    var response = await _frgnchks.SaveFrgnBatch(vm);
                    if (response > 0)
                    {
                        foreignChecksDetail.TotalAmount = Convert.ToDecimal(await _frgnchks.GetCheckTotal(foreignChecksDetail.BatchId));
                        var list = await _frgnchks.GetFrgnChksByBatchID(foreignChecksDetail.BatchId);
                        if (list.Successful)
                        {
                            List<FrgnCheckListVm> v = DataTableToModelConvert.CreateListFromTable<FrgnCheckListVm>(list.Value);
                            foreignChecksDetail.checksList = v;
                        }
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
                        foreignChecksDetail.BatchId = 24;
                        var response = await _frgnchks.AddFrgnCheack(foreignChecksDetail);
                        if (response.Successful)
                        {
                            foreignChecksDetail.CheckNumber = "";
                            foreignChecksDetail.PayerAcctNumber = "";
                            foreignChecksDetail.PayerAcctName = "";
                            foreignChecksDetail.DepositAcctName = "";
                            foreignChecksDetail.DepositAcctNumber = "";
                            foreignChecksDetail.CheckAmount = 0;
                            ModelState.Clear();
                            _notyf.Success("Check Saved successfully.");
                            foreignChecksDetail.TotalAmount = Convert.ToDecimal(response.Value);
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
                foreignChecksDetail.CheckNumber = "";
                foreignChecksDetail.PayerAcctNumber = "";
                foreignChecksDetail.PayerAcctName = "";
                foreignChecksDetail.DepositAcctName = "";
                foreignChecksDetail.DepositAcctNumber = "";
            }
            catch (Exception ex)
            {

                _notyf.Error("Server error!");
            }
            return View(foreignChecksDetail);

        }

        [HttpGet]
        public IActionResult UpdateFrgnCheck()
        {

            return View();
        }

        [HttpPost]
        public IActionResult UpdateFrgnCheck(ForeignCheckVm foreignCheck)
        {
            if (foreignCheck == null)
            {
                return BadRequest();
            }

            try
            {
                var response = _frgnchks.UpdateFrgn(foreignCheck);

                return View(response);
            }
            catch
            {
                throw;
            }
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

       
        [HttpGet]
        public JsonResult FrgncheckList()
        {
            var res = _frgnchks.GetAllforeign();
            return Json(res);
        }
        [HttpGet]
        public async Task<IActionResult> View(FrgnCheckViewRequest request)
        {
            FrgnViewCheckVm res = new FrgnViewCheckVm();
            res.entryStatusVM = new List<ForeignCheckStatusVM>();
            res.bankList = new List<BankListVm>();

            res.entryStatusVM = await _frgnchks.GetEntryStatus();
            res.bankList = await _sKNANBLIVEContext.Banks.Select(s => new BankListVm()
            {
                BankId = s.BankId,
                BankName = s.Name
            }).ToListAsync();

            List<FrgnCheckListRecVm> result = new List<FrgnCheckListRecVm>();

            switch (request.Options)
            {
                case 1:

                    var a = await _frgnchks.record(request.Status, "00", request.Banks, request.From, request.To);

                    if (a.Value != null)
                    {
                        result = DataTableToModelConvert.ConvertToList<FrgnCheckListRecVm>(a.Value);
                    }
                    break;

                case 2:

                    var b = await _frgnchks.record1(request.Status, "00", request.Banks, request.From, request.To);

                    if (b.Value != null)
                    {
                        result = DataTableToModelConvert.ConvertToList<FrgnCheckListRecVm>(b.Value);
                    }
                    break;

                case 3:
                    var c = await _frgnchks.record2(request.Status, "00", request.Banks, request.From, request.To);

                    if (c.Value != null)
                    {
                        result = DataTableToModelConvert.ConvertToList<FrgnCheckListRecVm>(c.Value);
                    }
                    break;
            }
            res.FrgnCheckListRecVms = result;
            return View(res);
        }

    }
}

