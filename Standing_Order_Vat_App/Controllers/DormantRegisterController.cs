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

        //public JsonResult GetDormantRegister(VmDormantRegister vmDormantRegister, string acctNumber)
        //{
        //    var res = _dormantRegister.GetDormantRegister(vmDormantRegister, acctNumber);
        //    var result = JsonConvert.SerializeObject(res);
        //    return new JsonResult(result);
        //}

        //[HttpGet]
        //public IActionResult UpdateDormantRegister(string? acctNumber, int recordId)
        //{
        //    var result = _dormantRegister.UpdateDormant(acctNumber, recordId);
        //    return View(result);
        //}

        //[HttpPost]
        //public IActionResult UpdateDormantRegister(VmDormantRegister dormantRegister)
        //{
        //    var result = _dormantRegister.UpdateDormant(dormantRegister);
        //    ViewBag.record = result;
        //    return RedirectToAction("ViewDormantRegister");
        //}

        //[HttpGet]
        //public IActionResult ViewDormantRegister(VmDormantRegisterData vmDormantRegisterData, string search, DateTime date, int? EntryStatusId, int pg = 1)
        //{
        //    var dormant = _dormantRegister.ViewDormant(search, EntryStatusId, date);
        //    var rec = _dormantRegister.GetEntityStatus();
        //    const int pageSize = 4;
        //    if (pg < 1)
        //        pg = 1;
        //    int recsCount = dormant.Count();
        //    var pager = new Pager(recsCount, pg, pageSize);
        //    int recSkip = (pg - 1) * pageSize;
        //    var data = dormant.Skip(recSkip).Take(pager.PageSize).ToList();
        //    this.ViewBag.Pager = pager;
        //    ViewBag.search = search;
        //    ViewBag.result = data;

        //    VmDormantRegisterData recorddata = new VmDormantRegisterData();
        //    recorddata.VmDormants = data;
        //    recorddata.EntityStatusVMs = rec;
        //    return View(recorddata);
        //}

        //[HttpPost]
        //public IActionResult ViewDormantRegister(VmDormantRegisterData vmDormantRegisterData)
        //{
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult DeleteDormantRegister(int recordId)
        //{
        //    var result = _dormantRegister.DeleteDormant(recordId);
        //    return RedirectToAction("ViewDormantRegister");
        //}

    }
}
