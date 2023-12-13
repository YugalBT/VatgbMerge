using AspNetCoreHero.ToastNotification.Abstractions;
using GbRegister.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.Services;
using Standing_Order_Vat_App.Common.ViewModels;
using static Standing_Order_Vat_App.MvcHelper.Enumration;

namespace Standing_Order_Vat_App.Controllers
{
    public class DormantRegisterController : Controller
    {
        private readonly IDormantRegister _dormantRegister;
        private readonly IAccountRepo accountRepo;
        private readonly IUserRole userRoleService;
        private readonly INotyfService notyf;

        public DormantRegisterController(IDormantRegister dormantRegister,IAccountRepo accountRepo, IUserRole userRoleService, INotyfService notyf)
        {
            _dormantRegister = dormantRegister;
            this.accountRepo = accountRepo;
            this.userRoleService = userRoleService;
            this.notyf = notyf;
        }
        public IActionResult Index()
        {
            userRoleService.GetUserRole(User.Identity.Name);
            if (!accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Foreign_Check.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddDormantRegister()
        {
            userRoleService.GetUserRole(User.Identity.Name);
            if (!accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Foreign_Check.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult AddDormantRegister(VmDormantRegister dormantRegister)
        {
            userRoleService.GetUserRole(User.Identity.Name);
            if (!accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Foreign_Check.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            var result = _dormantRegister.AddDormantRegister(dormantRegister);
            if (result.Successful)
            {
                notyf.Success(result.Message);
            }
            else
            {
                notyf.Warning(result.Message);
            }
            return RedirectToAction("AddDormantRegister");
        }
        public IGeneralResult<Accountinfo> GetAccountInfo(string AccNo)
        {
            Accountinfo vm = new Accountinfo();
            var res = _dormantRegister.GetAcctCoreInfo(ref vm, AccNo);
            return res;
        }

        [HttpPost]
        public async Task<IActionResult>UpdateDormant(DormantUpdateVmm res)
        {
            res.entryStatusVM = await _frgnchks.GetEntryStatus();
            res.status = 1;
            if (res.status == 1)
            {
                res.DormantListIncompletes = ListIncomplete(res);
            }
            else
            {
                res.DormantCheckListRecVms = ListComplete(res);

            }
            return View(res);
            
        }
        private List<DormantListRecVm> ListComplete(DormantUpdateVmm res)
        {
           
            List<DormantListRecVm> result1 = new List<DormantListRecVm>();
            res.coreBranch = _accountrepo.GetCoreId();
            res.jobTitle = _accountrepo.JobTitle();
            res.Department = _accountrepo.GetDepartment();
            
            switch (res.Options)
            {
                case 1:

                    var a = _dormantRegister.GetDormRegRecsByAcctNum(res.AccountNumber.ToString(), res.coreBranch, res.status, res.jobTitle,res.Department);
                    if (a.Value != null)
                    {
                        result1 = DataTableToModelConvert.ConvertToList<DormantListRecVm>(a.Value);

                    }
                    break;
                case 2:

                    var b = _dormantRegister.GetDormRegRecsByDate(res.dtFrom, res.dtTo, res.coreBranch, res.status, res.jobTitle);
                    if (b.Value != null)
                    {

                        result1 = DataTableToModelConvert.ConvertToList<DormantListRecVm>(b.Value);
                    }

                    break;



                case 3:

                    var c = _dormantRegister.GetDormRegRecsByStatus(res.status, res.coreBranch, res.jobTitle);
                    if (c.Value != null)
                    {
                        result1 = DataTableToModelConvert.ConvertToList<DormantListRecVm>(c.Value);

                    }
                    break;
            }
            res.DormantCheckListRecVms = result1;
            return result1;
           

        }
        private List<DormantListIncomplete> ListIncomplete(DormantUpdateVmm res)
        {
            List<DormantListIncomplete> result1 = new List<DormantListIncomplete>();
            res.coreBranch = _accountrepo.GetCoreId();
            res.jobTitle = _accountrepo.JobTitle();
            res.Department = _accountrepo.GetDepartment();

            switch (res.Options)
            {
                case 1:
                    var a = _dormantRegister.GetDormRegRecsByAcctNum(res.acct, res.coreBranch, res.status, res.jobTitle, res.Department);
                    if (a.Value != null)
                    {
                        if (res.status == 1)
                        {
                            result1 = DataTableToModelConvert.ConvertToList<DormantListIncomplete>(a.Value);
                        }
                    }
                    break;

                    
                case 2:

                    var b = _dormantRegister.GetDormRegRecsByDate(res.dtFrom, res.dtTo, res.coreBranch, res.status, res.jobTitle);
                    if (b.Value != null)
                    {

                        result1 = DataTableToModelConvert.ConvertToList<DormantListIncomplete>(b.Value);
                    }

                    break;
                case 3:
                    var c = _dormantRegister.GetDormRegRecsByStatus(res.status, res.coreBranch, res.jobTitle);
                    if (c.Value != null)
                    {
                        if (res.status == 1)
                        {
                            result1 = DataTableToModelConvert.ConvertToList<DormantListIncomplete>(c.Value);
                        }

                    }
                    break;
            }
            res.DormantListIncompletes = result1;
            return result1;
        }
        [HttpPost]
        public async Task<IGeneralResult<string>> DeleteDormant(int id)
        {
            IGeneralResult<string> res = new GeneralResult<string>();
            if (id > 0)
            {
                var result = await _dormantRegister.DeleteDormant(id);
                return result;
            }
            else
            {
                res.Message = "Batch Not Found!";
            }
            return res;
        }

    }
}
