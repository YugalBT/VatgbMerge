using GbRegister.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Standing_Order_Vat_App.Common.Interfaces;

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

        [HttpPost]
        public IActionResult ViewDormantRegister(VmDormantRegisterData vmDormantRegisterData)
        {
            return View();
        }

       

    }
}
