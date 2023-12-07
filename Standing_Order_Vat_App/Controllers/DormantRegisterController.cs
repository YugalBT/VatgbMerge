using GbRegister.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;

namespace Standing_Order_Vat_App.Controllers
{
    public class DormantRegisterController : Controller
    {
        private readonly IDormantRegister _dormantRegister;
        public DormantRegisterController(Common.Interfaces.IDormantRegister dormantRegister)
        {
            _dormantRegister = dormantRegister;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddDormantRegister()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDormantRegister(VmDormantRegister dormantRegister)
        {
            if (ModelState.IsValid)
            {
                var result = _dormantRegister.AddDormantRegister(dormantRegister);
                ViewBag.record = result;
            }
            return View("AddDormantRegister");
        }
        public void GetAccountInfo(string AccNo)
        {
            Accountinfo vm = new Accountinfo();
            var res = _dormantRegister.GetAcctCoreInfo(ref vm, AccNo);
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
