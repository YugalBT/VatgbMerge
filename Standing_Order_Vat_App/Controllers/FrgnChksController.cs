﻿using AspNetCoreHero.ToastNotification.Abstractions;
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
using DocumentFormat.OpenXml.Office2016.Excel;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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

        [HttpPost]
        public async Task<IActionResult> AddFrgnCheckAsync(ForeignCheckVm foreignChecksDetail)
        {

            try
            {
                foreignChecksDetail.BatchId = 24;

                if (foreignChecksDetail != null)
                {
                    var response = await _frgnchks.AddFrgnCheack(foreignChecksDetail);
                    if (response.Successful)
                    {
                        var list = await _frgnchks.GetFrgnChksByBatchID(foreignChecksDetail.BatchId);
                        if (list.Successful)
                        {
                            List<FrgnCheckListVm> v = DataTableToModelConvert.CreateListFromTable<FrgnCheckListVm>(list.Value);
                            foreignChecksDetail.checksList = v;
                            return View(foreignChecksDetail);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
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
        [HttpPost]
        public async Task<bool> SaveFrgnBatchHeader(FrgnCheckVm frgnCheckVm)
        {
            frgnCheckVm.dtProcessed = DateTime.Now;
            frgnCheckVm.empId = 29;
            frgnCheckVm.batchStat = 1;
            frgnCheckVm.branch = "00";
            var response = await _frgnchks.SaveFrgnBatch(frgnCheckVm);
            if (response.BatchId > 0)
            {
                return true;
            }
            return false;
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
        [HttpGet]
        public async Task<IActionResult>UpdateFrgn(FrgnCheckViewRequest request)
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

       public IActionResult DeletefrgnCheck(int batchid)
        {
            try
            {
                var res=_frgnchks.DeleteFrgnChksBatch(batchid);

            }
            catch(Exception ex)
            {

            }
            return View();
        }
    }
}
