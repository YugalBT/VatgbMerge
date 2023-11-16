using AspNetCoreHero.ToastNotification.Abstractions;
using GbRegister.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.GB_Register;
using Standing_Order_Vat_App.DAL.SKNANB_LIVE;
using Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB;
using System.Web.Helpers;

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
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddFrgnCheckAsync(ForeignCheckVm foreignChecksDetail)
        {
            if (foreignChecksDetail == null)
            {
                return BadRequest();
            }

            try
            {
                var response = await _frgnchks.AddFrgnCheack(foreignChecksDetail);

                return View(response);
            }
            catch
            {
                throw;
            }
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
                var response =  _frgnchks.UpdateFrgn(foreignCheck);

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

       

        [HttpPost]
        public async Task<bool> SaveFrgnBatchHeader(FrgnCheckVm frgnCheckVm)
        {
            frgnCheckVm.dtProcessed = DateTime.Now;
            frgnCheckVm.empId = 29;
            frgnCheckVm.batchStat = 1;
            frgnCheckVm.branch = "00";
            var response =  await _frgnchks.SaveFrgnBatch(frgnCheckVm);
            if(response.BatchId > 0)
            {
                return true;
            }
            return false;
        }

        [HttpGet]
        public JsonResult FrgncheckList()
        {
            var res=_frgnchks.GetAllforeign();
            return Json(res);
        }
    }
}

