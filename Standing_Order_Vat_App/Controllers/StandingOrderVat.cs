using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.MvcHelper;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Grid;
using System.Diagnostics;
using System.Security.Claims;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using System.Reflection;
using static Standing_Order_Vat_App.Controllers.CustomerSummaryController;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.ExtendedProperties;
using AspNetCoreHero.ToastNotification.Abstractions;
using Standing_Order_Vat_App.Common.Helper;
using static Standing_Order_Vat_App.MvcHelper.Enumration;

namespace Standing_Order_Vat_App.Controllers
{

    public class StandingOrderVatController : Controller
    {
        const string Sessionuid = "uid";
        const string Sessionuname = "uname";
        const string Sessionurole = "urole";
        const string Sessionusercount = "ucount";
        private readonly IUserRole userRoleService;
        private readonly IgetSummary summaryrecordservices;
        private readonly IGetDDACReport getDDACReportservice;
        private readonly IGetLoanCharge getLoanChargeservice;
        private readonly IStopPayCharge getstopPayChargeservice;
        private readonly ITansChargeBranch getTansChargeBranchservise;
        private readonly ISafekeepingPayments getSafekeepingPayments;
        private readonly IVATOnFraudCharge vATOnFraudCharge;
        private readonly ITransactionCharges transactionCharge;
        private readonly ICustomerdetail customerdetail;
        private readonly IAccountRepo accountRepo;
        private readonly INotyfService notyf;
        //private readonly SetUserPermissions setUserPermissions;
        string result;
        int userId;
        string ssnum;
        int empID;
        GetCurrentUserInfoVm userInfo;


        public StandingOrderVatController(IUserRole userRoleService, IgetSummary summaryrecordservices, IGetDDACReport getDDACReportservice,
            IGetLoanCharge getLoanChargeservice, IStopPayCharge getstopPayChargeservice, ITansChargeBranch getTansChargeBranchservise
            , ISafekeepingPayments getSafekeepingPayments, IVATOnFraudCharge vATOnFraudCharge, ITransactionCharges transactionCharge,
            ICustomerdetail customerdetail, IAccountRepo accountRepo, INotyfService notyf)
        {
            this.userRoleService = userRoleService;
            this.summaryrecordservices = summaryrecordservices;
            this.getDDACReportservice = getDDACReportservice;
            this.getLoanChargeservice = getLoanChargeservice;
            this.getstopPayChargeservice = getstopPayChargeservice;
            this.getTansChargeBranchservise = getTansChargeBranchservise;
            this.getSafekeepingPayments = getSafekeepingPayments;
            this.vATOnFraudCharge = vATOnFraudCharge;
            this.transactionCharge = transactionCharge;
            this.customerdetail = customerdetail;
            this.accountRepo = accountRepo;
            this.notyf = notyf;
            //this.setUserPermissions = setUserPermissions;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> TotalSummaryReport(Summery_VM obj, int pn = 1, int recordPerPage = 10, int branche = 0, int report = 0, DateTime fdate = default, DateTime tdate = default)
        {
            //setUserPermissions.SetPermissionsInSession();
            int empid = accountRepo.GetUserinfo(ref result, ref userInfo);
            var rec = userRoleService.GetUserRole(User.Identity.Name);

            printlog("Status: Application Start");
            if (!accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Vat.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied","Home");
            }
            List<Customer_VM> customers = new List<Customer_VM>();

            Summery_VM record = new Summery_VM();
            DateTime dt = new DateTime();

            if (!string.IsNullOrEmpty(HttpContext.Request.Query["fdate"]) && !string.IsNullOrEmpty(HttpContext.Request.Query["tdate"]))
            {
                obj.dateFrom = Convert.ToDateTime(HttpContext.Request.Query["fdate"]);
                obj.DateTo = Convert.ToDateTime(HttpContext.Request.Query["tdate"]);
            }
            if (fdate != dt)
            {
                obj.Branch = branche;
                obj.Report = report;
                // record.dateFrom = fdate;
                //   record.DateTo = tdate;
                obj.dateFrom = fdate;
                obj.DateTo = tdate;
            }

            customers = customerdetail.GetCustomerDetail(obj.Report);
            printlog("User Name: " + User.Identity.Name);
            List<UserRole_VM> userRolelist = new List<UserRole_VM>();
            userRolelist = rec.Select(x => ((UserRole_VM)x)).ToList();

            ViewBag.pageno = pn;

            printlog("User List Count: " + userRolelist.Count.ToString());
            printlog("User Name: " + User.Identity.Name);
            printlog("App Name: NB_VAT_FEES");

            record.UserRole_VMs = userRolelist;

            //HttpContext.Session.SetString(Sessionusercount, userRolelist.Count.ToString());

            if (userRolelist.Count > 0)
            {

                printlog("Role ID: " + userRolelist.FirstOrDefault().RoleID.ToString());
                printlog("User Name: " + userRolelist.FirstOrDefault().UserName.ToString());
                printlog("User Role Name: " + userRolelist.FirstOrDefault().RoleName.ToString());

                //HttpContext.Session.SetInt32(Sessionuid, Convert.ToInt32(userRolelist.FirstOrDefault().RoleID));
                //HttpContext.Session.SetString(Sessionuname, userRolelist.FirstOrDefault().UserName);
                //HttpContext.Session.SetString(Sessionurole, userRolelist.FirstOrDefault().RoleName);

                string branch;
                long TotalRecord = 0;
                // Summery_VM record = new Summery_VM();
                record.isvalue = false;
                TempData["pn"] = pn + "";
                switch (accountRepo.Geturole())
                {
                    case "Main Branch":
                    case "Credit":
                        {
                            branch = "0";
                            break;
                        }
                    case "NB Nevis":
                        {
                            branch = "1";
                            break;
                        }
                    case "Sandy Point":
                        {
                            branch = "2";
                            break;
                        }
                    case "Saddlers":
                        {
                            branch = "3";
                            break;
                        }
                    case "Pelican Mall":
                        {
                            branch = "4";
                            break;
                        }
                    case "Manager":
                    case "Executive":
                        {
                            branch = obj.Branch.ToString();
                            break;
                        }
                }

                switch (obj.Report)
                {
                    case 1:
                        {
                            if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                            {
                                //You are not authorized to view this report
                                ViewBag.Message = String.Format("You are not authorized to view this report");
                            }
                            else
                            {
                                record.Report = 1;
                                record.StandingOrder = summaryrecordservices.GetSummaryReport(obj, pn - 1, recordPerPage);


                                if (record.StandingOrder.Count > 0)
                                {
                                    TotalRecord = (long)record.StandingOrder.FirstOrDefault().TotalRecordCount;
                                    record.isvalue = true;
                                }
                                else
                                {
                                    ViewBag.errormsg = String.Format("No record found.");
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                            {
                                ViewBag.Message = String.Format("You are not authorized to view this report");
                            }
                            else
                            {
                                record.Report = 2;
                                record.DDASCReport_VMs = getDDACReportservice.GetDDASCReport(obj, pn - 1, recordPerPage);

                                if (record.DDASCReport_VMs.Count > 0)
                                {
                                    TotalRecord = (long)record.DDASCReport_VMs.FirstOrDefault().TotalRecordCount;
                                    record.isvalue = true;
                                }
                                else
                                {
                                    ViewBag.errormsg = String.Format("No record found.");
                                }
                            }

                            break;
                        }
                    case 3:
                        {
                            if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                            {
                                ViewBag.Message = String.Format("You are not authorized to view this report");
                            }
                            else
                            {
                                record.Report = 3;
                                record.LoanCharge_VMs = getLoanChargeservice.GetLoanCharge(obj, pn - 1, recordPerPage);
                                if (record.LoanCharge_VMs.Count > 0)
                                {
                                    TotalRecord = (long)record.LoanCharge_VMs.FirstOrDefault().TotalRecordCount;
                                    record.isvalue = true;
                                }
                                else
                                {
                                    ViewBag.errormsg = String.Format("No record found.");
                                }
                            }


                            break;
                        }
                    case 4:
                        {
                            if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                            {
                                ViewBag.Message = String.Format("You are not authorized to view this report");
                            }
                            else
                            {
                                record.Report = 4;
                                record.StopPayCharge_VMs = getstopPayChargeservice.GetStopPayCharge(obj, pn - 1, recordPerPage);

                                if (record.StopPayCharge_VMs.Count > 0)
                                {
                                    TotalRecord = (long)record.StopPayCharge_VMs.FirstOrDefault().TotalRecordCount;
                                    record.isvalue = true;
                                }
                                else
                                {
                                    ViewBag.errormsg = String.Format("No record found.");
                                }
                            }

                            break;
                        }
                    case 5:
                        {
                            if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                            {
                                ViewBag.Message = String.Format("You are not authorized to view this report");
                            }
                            else
                            {
                                record.Report = 5;
                                record.TansChargeBranch_VMs = getTansChargeBranchservise.GetTansChargeBranch(obj, pn - 1, recordPerPage);
                                if (record.TansChargeBranch_VMs.Count > 0)
                                {
                                    TotalRecord = (long)record.TansChargeBranch_VMs.FirstOrDefault().TotalRecordCount;
                                    record.isvalue = true;
                                }
                                else
                                {
                                    ViewBag.errormsg = String.Format("No record found.");
                                }
                            }


                            break;
                        }
                    case 6:
                        {
                            if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                            {
                                ViewBag.Message = String.Format("You are not authorized to view this report");
                            }
                            else
                            {
                                record.Report = 6;
                                record.SafekeepingPayment_VMs = getSafekeepingPayments.getSafekeepingPayments(obj, pn - 1, recordPerPage);
                                if (record.SafekeepingPayment_VMs.Count > 0)
                                {
                                    TotalRecord = (long)record.SafekeepingPayment_VMs.FirstOrDefault().TotalRecordCount;
                                    record.isvalue = true;
                                }
                                else
                                {
                                    ViewBag.errormsg = String.Format("No record found.");
                                }
                            }
                            break;
                        }
                    case 7:
                        {
                            if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Executive" || HttpContext.Session.GetString(Sessionurole)?.ToString() == "Admin")
                            {
                                decimal totVat, totNatFees, grandTotal;
                                totVat = totNatFees = grandTotal = 0;
                                List<VATOnFraudCharge_VM> vATOnFraudCharge_VMs = new List<VATOnFraudCharge_VM>();
                                var rec1 = await vATOnFraudCharge.GetVATFraudCharge(obj);

                                vATOnFraudCharge_VMs = rec1.Select(x => ((VATOnFraudCharge_VM)x)).ToList();

                                if (vATOnFraudCharge_VMs.Count > 0)
                                {
                                    totVat = ((decimal)vATOnFraudCharge_VMs.Sum(s => s.VAT));
                                    totNatFees = (decimal)vATOnFraudCharge_VMs.Sum(s => s.National_Fees);
                                    grandTotal = (decimal)vATOnFraudCharge_VMs.Sum(s => s.SubTotal);
                                    record.Report = 7;

                                    record.isvalue = true;

                                    ViewBag.totvat = totVat;
                                    ViewBag.totnetfees = totNatFees;
                                    ViewBag.grandtotal = grandTotal;
                                }
                                else
                                {
                                    ViewBag.errormsg = String.Format("No record found.");
                                }

                            }
                            else
                            {
                                ViewBag.Message = String.Format("You are not authorized to view this report");

                            }
                            break;
                        }
                    case 8:
                        {
                            if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Executive" || HttpContext.Session.GetString(Sessionurole)?.ToString() == "Admin")
                            {

                                List<VATOnFraudCharge_VM> vATOnFraudCharge_VMs = new List<VATOnFraudCharge_VM>();
                                var rec2 = await transactionCharge.GetVATFraudCharge(obj);

                                record.VATOnTransacactionVMs = rec2.Select(x => ((VATOnTransactionCharge_VM)x)).ToList();
                                if (record.VATOnTransacactionVMs.Count > 0)
                                {
                                    record.Report = 8;
                                    record.isvalue = true;
                                }
                                else
                                {
                                    ViewBag.errormsg = String.Format("No record found.");
                                }
                            }
                            else
                            {
                                ViewBag.Message = String.Format("You are not authorized to view this report");
                            }
                            break;
                        }
                }
                record.Branch = obj.Branch;
                record.dateFrom = obj.dateFrom;
                record.DateTo = obj.DateTo;
                record.search = obj.search;
                ViewData["Paging"] = PaginationView.Set_Paging(pn, recordPerPage, TotalRecord, "active", Url.Action("TotalSummaryReport"), "disableLink", record.Branch, record.Report, record.dateFrom, record.DateTo, record.search);
            }
            else
            {
                ViewBag.Message = String.Format(User.Identity.Name.ToString() + " is not registered. please contact to the Admin");
            }
            return View(record);

        }

        [HttpGet]
        public async Task<IActionResult> ExportListUsingEPPlus(int pn = 1, int recordPerPage = 10, int brchno = 0, int report = 0, DateTime fdate = default, DateTime tdate = default, int doctype = 0, string search = "")
        {
            if (!accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Vat.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            Summery_VM record = new Summery_VM();
            ulong TotalRecord = 0;
            record.Branch = brchno;
            record.Report = report;
            record.dateFrom = fdate;
            record.DateTo = tdate;
            record.search = search;
            string downloadFileName = "";

            if (!string.IsNullOrEmpty(HttpContext.Request.Query["fdate"]) && !string.IsNullOrEmpty(HttpContext.Request.Query["tdate"]))
            {
                record.dateFrom = Convert.ToDateTime(HttpContext.Request.Query["fdate"]);
                record.DateTo = Convert.ToDateTime(HttpContext.Request.Query["tdate"]);
            }
            dynamic result = record;
            switch (report)
            {
                case 1:
                    {
                        if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                        {
                            //You are not authorized to view this report
                            ViewBag.Message = String.Format("You are not authorized to view this report");
                        }
                        else
                        {
                            record.Report = 1;
                            result = summaryrecordservices.GetSummaryReportDawnload(record);
                        }

                        break;
                    }
                case 2:
                    {
                        if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                        {
                            ViewBag.Message = String.Format("You are not authorized to view this report");
                        }
                        else
                        {
                            record.Report = 2;
                            result = getDDACReportservice.GetDDASCReportDawnload(record);
                        }

                        break;
                    }
                case 3:
                    {
                        if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                        {
                            ViewBag.Message = String.Format("You are not authorized to view this report");
                        }
                        else
                        {
                            record.Report = 3;
                            result = getLoanChargeservice.GetLoanChargeDawnload(record);
                            //TotalRecord = (ulong)record.LoanCharge_VMs.FirstOrDefault().TotalRecordCount;
                        }


                        break;
                    }
                case 4:
                    {
                        if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                        {
                            ViewBag.Message = String.Format("You are not authorized to view this report");
                        }
                        else
                        {
                            record.Report = 4;
                            result = getstopPayChargeservice.GetStopPayChargeDawnload(record);
                            //TotalRecord = (ulong)record.StopPayCharge_VMs.FirstOrDefault().TotalRecordCount;

                        }

                        break;
                    }
                case 5:
                    {
                        if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                        {
                            ViewBag.Message = String.Format("You are not authorized to view this report");
                        }
                        else
                        {
                            record.Report = 5;
                            result = getTansChargeBranchservise.GetTansChargeBranchDawnload(record);
                            //TotalRecord = (ulong)record.TansChargeBranch_VMs.FirstOrDefault().TotalRecordCount;

                        }


                        break;
                    }
                case 6:
                    {
                        if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                        {
                            ViewBag.Message = String.Format("You are not authorized to view this report");
                        }
                        else
                        {
                            record.Report = 6;
                            result = getSafekeepingPayments.getSafekeepingPaymentsDawnload(record);
                            //TotalRecord = (ulong)record.SafekeepingPayment_VMs.FirstOrDefault().TotalRecordCount;

                        }
                        break;
                    }
                case 7:
                    {
                        if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Executive")
                        {
                            decimal totVat, totNatFees, grandTotal;
                            totVat = totNatFees = grandTotal = 0;
                            List<VATOnFraudCharge_VM> vATOnFraudCharge_VMs = new List<VATOnFraudCharge_VM>();
                            var rec1 = await vATOnFraudCharge.GetVATFraudCharge(record);

                            result = rec1.Select(x => ((VATOnFraudCharge_VM)x)).ToList();

                            if (vATOnFraudCharge_VMs.Count > 0)
                            {
                                totVat = ((decimal)vATOnFraudCharge_VMs.Sum(s => s.VAT));
                                totNatFees = (decimal)vATOnFraudCharge_VMs.Sum(s => s.National_Fees);
                                grandTotal = (decimal)vATOnFraudCharge_VMs.Sum(s => s.SubTotal);
                                record.Report = 7;
                                ViewBag.totvat = totVat;
                                ViewBag.totnetfees = totNatFees;
                                ViewBag.grandtotal = grandTotal;
                            }
                            record.isvalue = true;
                        }
                        else
                        {
                            ViewBag.Message = String.Format("You are not authorized to view this report");
                        }
                        break;
                    }
                case 8:
                    {
                        if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Executive")
                        {

                            List<VATOnTransactionCharge_VM> vATOnFraudCharge_VMs = new List<VATOnTransactionCharge_VM>();
                            var rec3 = await transactionCharge.GetVATFraudCharge(record);

                            result = rec3.Select(x => ((VATOnTransactionCharge_VM)x)).ToList();
                            record.Report = 8;
                            if (record.VATOnTransacactionVMs.Count > 0)
                            {
                                record.isvalue = true;
                            }

                        }
                        else
                        {
                            ViewBag.Message = String.Format("You are not authorized to view this report");
                        }
                        break;
                    }


            }

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Sheet1");

            workSheet.Cells[1, 1].Value = $"Branch: {Extensions.GetEnumDisplayName((BranchName)record.Branch)}";
            workSheet.Cells[2, 1].Value = $"Report: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}";
            workSheet.Cells[3, 1].Value = $"StartDate: {record.dateFrom.Date.ToString("MM / dd / yyyy")}";
            workSheet.Cells[4, 1].Value = $"EndDate: {record.DateTo.Date.ToString("MM/dd/yyyy")}";


            workSheet.Cells[6, 1].LoadFromCollection(result, true);
            // pdf maker
            PdfDocument doc = new PdfDocument();

            if (doctype == 2)
            {
                //Add a page.
                PdfPage page = doc.Pages.Add();
                //Create a PdfGrid.
                PdfGrid pdfGrid = new PdfGrid();
                pdfGrid.DataSource = result;
                //Draw grid to the page of PDF document.
                pdfGrid.Draw(page, new Syncfusion.Drawing.PointF(10, 80));
                PdfPageBase page1 = doc.Pages[0] as PdfPageBase;
                PdfGraphics graphics = page.Graphics;
                PdfFont graphicFont = new PdfStandardFont(PdfFontFamily.Helvetica, 10);
                graphics.DrawString($"Branch: {Extensions.GetEnumDisplayName((BranchName)record.Branch)}\nReport: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}\nStartDate: {record.dateFrom.Date.ToString("MM/dd/yyyy")}\nEndDate:{record.DateTo.Date.ToString("MM/dd/yyyy")}", graphicFont, PdfBrushes.Black, new PointF(10, 10));
            }
            WordDocument document = new WordDocument();
            if (doctype == 3)
            {
                switch (report)
                {
                    case 1:
                        {
                            IWSection section = document.AddSection();

                            section.AddParagraph().AppendText("Standing Orders & VAT Fees Summary");
                            section.AddParagraph().AppendText($"Branch: {Extensions.GetEnumDisplayName((BranchName)record.Branch)}");
                            section.AddParagraph().AppendText($"Report: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}");
                            section.AddParagraph().AppendText($"StartDate: {record.dateFrom.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph().AppendText($"EndDate:{record.DateTo.Date.ToString("MM/dd/yyyy")}");

                            section.AddParagraph();

                            //Adds a new table into Word document
                            IWTable table = section.AddTable();

                            //Adds the first row into table
                            WTableRow row = table.AddRow();
                            //Adds the first cell into first row 
                            WTableCell cell = row.AddCell();

                            cell.Width = 55;
                            cell.AddParagraph().AppendText("Branch Number");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 70;
                            cell.AddParagraph().AppendText("Date");
                            cell = row.AddCell();

                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Acct");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Customer Name");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 70;
                            cell.AddParagraph().AppendText("Off set Acct Number");

                            cell = row.AddCell();
                            cell.Width = 50;
                            cell.AddParagraph().AppendText("Total");

                            //Adds the second cell into first row 
                            cell = row.AddCell();
                            cell.Width = 100;
                            cell.AddParagraph().AppendText("National Fees");

                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Vat");

                            //Adds the second cell into first row 
                            foreach (var item in result)
                            {
                                StandingOrder_VM_Download svm = new StandingOrder_VM_Download();
                                svm = (StandingOrder_VM_Download)item;
                                row = table.AddRow(true, false);
                                //Adds the first cell into second row
                                cell = row.AddCell();
                                cell.Width = 55;
                                cell.AddParagraph().AppendText(svm.BranchNumber == null ? "" : svm.BranchNumber);

                                cell = row.AddCell();
                                cell.Width = 70;
                                cell.AddParagraph().AppendText(svm.DateActive == null ? "" : svm.DateActive);

                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Acct == null ? "" : svm.Acct);

                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.CustomerName == null ? "" : svm.CustomerName);

                                cell = row.AddCell();
                                cell.Width = 70;
                                cell.AddParagraph().AppendText(svm.OffsetAcctNumber == null ? "" : svm.OffsetAcctNumber);
                                cell = row.AddCell();
                                cell.Width = 50;
                                cell.AddParagraph().AppendText(svm.TotalFees.ToString());
                                cell = row.AddCell();
                                cell.Width = 100;
                                cell.AddParagraph().AppendText(svm.NationalFees.ToString());
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Vat.ToString());

                            }
                            break;
                        }
                    case 2:
                        {
                            IWSection section = document.AddSection();
                            section.AddParagraph().AppendText("Standing Orders & VAT Fees Summary");
                            section.AddParagraph().AppendText($"Branch: {Extensions.GetEnumDisplayName((BranchName)record.Branch)}");
                            section.AddParagraph().AppendText($"Report: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}");
                            section.AddParagraph().AppendText($"StartDate: {record.dateFrom.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph().AppendText($"EndDate:{record.DateTo.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph();
                            //Adds a new table into Word document
                            IWTable table = section.AddTable();
                            //Adds the first row into table
                            WTableRow row = table.AddRow();
                            //Adds the first cell into first row 
                            WTableCell cell = row.AddCell();

                            cell.Width = 55;
                            cell.AddParagraph().AppendText("Account");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 100;
                            cell.AddParagraph().AppendText("Customer Name");
                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Date");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 70;
                            cell.AddParagraph().AppendText("Charged");

                            //Adds the second cell into first row 


                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Vat");

                            cell = row.AddCell();
                            cell.Width = 100;
                            cell.AddParagraph().AppendText("National Fees");

                            //Adds the second cell into first row 
                            foreach (var item in result)
                            {
                                DDASCReport_VM_Download svm = new DDASCReport_VM_Download();
                                svm = (DDASCReport_VM_Download)item;
                                row = table.AddRow(true, false);
                                //Adds the first cell into second row
                                cell = row.AddCell();
                                cell.Width = 55;
                                cell.AddParagraph().AppendText(svm.ACCT == null ? "" : svm.ACCT);
                                cell = row.AddCell();
                                cell.Width = 100;
                                cell.AddParagraph().AppendText(svm.Customer_Name.ToString());
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.RptDate == null ? "" : svm.RptDate);
                                cell = row.AddCell();
                                cell.Width = 70;
                                cell.AddParagraph().AppendText(svm.Charged.ToString());
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.VAT.ToString());
                                cell = row.AddCell();
                                cell.Width = 100;
                                cell.AddParagraph().AppendText(svm.National_Fees.ToString());

                            }
                            break;
                        }
                    case 3:
                        {
                            IWSection section = document.AddSection();
                            section.AddParagraph().AppendText("Loan Charges Fees & VAT Summary");

                            section.AddParagraph().AppendText($"Branch: {Extensions.GetEnumDisplayName((BranchName)record.Branch)}");
                            section.AddParagraph().AppendText($"Report: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}");
                            section.AddParagraph().AppendText($"StartDate: {record.dateFrom.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph().AppendText($"EndDate:{record.DateTo.Date.ToString("MM/dd/yyyy")}");

                            section.AddParagraph();
                            IWTable table = section.AddTable();
                            WTableRow row = table.AddRow();
                            WTableCell cell = row.AddCell();

                            cell.Width = 55;
                            cell.AddParagraph().AppendText("Branch");
                            cell = row.AddCell();

                            cell.Width = 100;
                            cell.AddParagraph().AppendText("Acct");
                            cell = row.AddCell();

                            cell.Width = 100;
                            cell.AddParagraph().AppendText("Customer Name");
                            cell = row.AddCell();

                            cell.Width = 70;
                            cell.AddParagraph().AppendText("Dateactive");
                            cell = row.AddCell();

                            cell.Width = 70;
                            cell.AddParagraph().AppendText("Total fees");

                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("National fees");

                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Vat");

                            foreach (var item in result)
                            {
                                LoanCharge_VM_Download svm = new LoanCharge_VM_Download();
                                svm = (LoanCharge_VM_Download)item;
                                row = table.AddRow(true, false);
                                //Adds the first cell into second row
                                cell = row.AddCell();
                                cell.Width = 55;
                                cell.AddParagraph().AppendText(svm.Branch == null ? "" : svm.Branch);
                                cell = row.AddCell();
                                cell.Width = 100;
                                cell.AddParagraph().AppendText(svm.Acct == null ? "" : svm.Acct);
                                cell = row.AddCell();
                                cell.Width = 100;
                                cell.AddParagraph().AppendText(svm.Name == null ? "" : svm.Name);
                                cell = row.AddCell();
                                cell.Width = 70;
                                cell.AddParagraph().AppendText(svm.Dateactive == null ? "" : svm.Dateactive);
                                cell = row.AddCell();
                                cell.Width = 70;
                                cell.AddParagraph().AppendText(svm.Totalfees.ToString());
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Nationalfees.ToString());
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Vat.ToString());
                            }
                            break;
                        }
                    case 4:
                        {
                            IWSection section = document.AddSection();
                            section.AddParagraph().AppendText("Standing Orders & VAT Fees Summary");
                            section.AddParagraph().AppendText($"Branch: {Extensions.GetEnumDisplayName((BranchName)record.Branch)}");
                            section.AddParagraph().AppendText($"Report: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}");
                            section.AddParagraph().AppendText($"StartDate: {record.dateFrom.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph().AppendText($"EndDate:{record.DateTo.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph();
                            //Adds a new table into Word document
                            IWTable table = section.AddTable();
                            //Adds the first row into table
                            WTableRow row = table.AddRow();
                            //Adds the first cell into first row 
                            WTableCell cell = row.AddCell();

                            cell.Width = 50;
                            cell.AddParagraph().AppendText("Cif");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 50;
                            cell.AddParagraph().AppendText("Account");
                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Date");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 50;
                            cell.AddParagraph().AppendText("Branch");

                            cell = row.AddCell();
                            cell.Width = 50;
                            cell.AddParagraph().AppendText("Prof of Sequence");

                            //Adds the second cell into first row 
                            cell = row.AddCell();
                            cell.Width = 50;
                            cell.AddParagraph().AppendText("Check Number");

                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Total");
                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("NationalFees");
                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Vat");

                            //Adds the second cell into first row 
                            foreach (var item in result)
                            {
                                StopPayCharge_VM_Download svm = new StopPayCharge_VM_Download();
                                svm = (StopPayCharge_VM_Download)item;
                                row = table.AddRow(true, false);
                                //Adds the first cell into second row
                                cell = row.AddCell();
                                cell.Width = 50;
                                cell.AddParagraph().AppendText(svm.Cif == null ? "" : svm.Cif);
                                cell = row.AddCell();
                                cell.Width = 50;
                                cell.AddParagraph().AppendText(svm.Acct == null ? "" : svm.Acct);
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Dateactive == null ? "" : svm.Dateactive);
                                cell = row.AddCell();
                                cell.Width = 50;
                                cell.AddParagraph().AppendText(svm.Branch == null ? "" : svm.Branch);
                                cell = row.AddCell();
                                cell.Width = 50;
                                cell.AddParagraph().AppendText(svm.ProofSequence == null ? "" : svm.ProofSequence);
                                cell = row.AddCell();
                                cell.Width = 50;
                                cell.AddParagraph().AppendText(svm.CheckNumber.ToString());
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.TransAmt.ToString());
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.NationalFees.ToString());
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Vat.ToString());

                            }
                            break;
                        }
                    case 5:
                        {
                            IWSection section = document.AddSection();
                            section.AddParagraph().AppendText("Transfer Charges Summary Report");
                            section.AddParagraph().AppendText($"Branch: {Extensions.GetEnumDisplayName((BranchName)record.Branch)}");
                            section.AddParagraph().AppendText($"Report: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}");
                            section.AddParagraph().AppendText($"StartDate: {record.dateFrom.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph().AppendText($"EndDate:{record.DateTo.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph();
                            //Adds a new table into Word document
                            IWTable table = section.AddTable();
                            //Adds the first row into table
                            WTableRow row = table.AddRow();
                            //Adds the first cell into first row 
                            WTableCell cell = row.AddCell();

                            cell.Width = 55;
                            cell.AddParagraph().AppendText("Cif");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 100;
                            cell.AddParagraph().AppendText("Account");
                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Date");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 70;
                            cell.AddParagraph().AppendText("Branch");

                            cell = row.AddCell();
                            cell.Width = 50;
                            cell.AddParagraph().AppendText("Transaction Amount");

                            //Adds the second cell into first row 
                            cell = row.AddCell();
                            cell.Width = 100;
                            cell.AddParagraph().AppendText("National Fees");

                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Vat");

                            //Adds the second cell into first row 
                            foreach (var item in result)
                            {
                                TansChargeBranch_VM_Download svm = new TansChargeBranch_VM_Download();
                                svm = (TansChargeBranch_VM_Download)item;
                                row = table.AddRow(true, false);
                                //Adds the first cell into second row
                                cell = row.AddCell();
                                cell.Width = 55;
                                cell.AddParagraph().AppendText(svm.Cif == null ? "" : svm.Cif);
                                cell = row.AddCell();
                                cell.Width = 100;
                                cell.AddParagraph().AppendText(svm.Acct == null ? "" : svm.Acct);
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Dateactive == null ? "" : svm.Dateactive);
                                cell = row.AddCell();
                                cell.Width = 70;
                                cell.AddParagraph().AppendText(svm.Branch.ToString());
                                cell = row.AddCell();
                                cell.Width = 50;
                                cell.AddParagraph().AppendText(svm.TransAmt.ToString());
                                cell = row.AddCell();
                                cell.Width = 100;
                                cell.AddParagraph().AppendText(svm.NationalFees.ToString());
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Vat.ToString());

                            }
                            break;
                        }
                    case 6:
                        {
                            IWSection section = document.AddSection();
                            section.AddParagraph().AppendText("Safe Keeping Summary");
                            section.AddParagraph().AppendText($"Branch: {Extensions.GetEnumDisplayName((BranchName)record.Branch)}");
                            section.AddParagraph().AppendText($"Report: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}");
                            section.AddParagraph().AppendText($"StartDate: {record.dateFrom.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph().AppendText($"EndDate:{record.DateTo.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph();
                            //Adds a new table into Word document
                            IWTable table = section.AddTable();
                            //Adds the first row into table
                            WTableRow row = table.AddRow();
                            //Adds the first cell into first row 
                            WTableCell cell = row.AddCell();

                            cell.Width = 55;
                            cell.AddParagraph().AppendText("Acct");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 100;
                            cell.AddParagraph().AppendText("Dateactive");
                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Branch");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 70;
                            cell.AddParagraph().AppendText("Trasncode");

                            cell = row.AddCell();
                            cell.Width = 50;
                            cell.AddParagraph().AppendText("Prof Of Sequence");

                            //Adds the second cell into first row 
                            cell = row.AddCell();
                            cell.Width = 100;
                            cell.AddParagraph().AppendText("Check Number");

                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Total");
                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("National Fees");
                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Vat");

                            //Adds the second cell into first row 
                            foreach (var item in result)
                            {
                                SafekeepingPayment_VM_Download svm = new SafekeepingPayment_VM_Download();
                                svm = (SafekeepingPayment_VM_Download)item;
                                row = table.AddRow(true, false);
                                //Adds the first cell into second row
                                cell = row.AddCell();
                                cell.Width = 55;
                                cell.AddParagraph().AppendText(svm.Acct == null ? "0" : svm.Acct);
                                cell = row.AddCell();
                                cell.Width = 100;
                                cell.AddParagraph().AppendText(svm.Dateactive == null ? "" : svm.Dateactive);
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Branch.ToString());
                                cell = row.AddCell();
                                cell.Width = 70;
                                cell.AddParagraph().AppendText(svm.Transcode == null ? "" : svm.Transcode);
                                cell = row.AddCell();
                                cell.Width = 50;
                                cell.AddParagraph().AppendText(svm.ProofSequence == null ? "" : svm.ProofSequence);
                                cell = row.AddCell();
                                cell.Width = 100;
                                cell.AddParagraph().AppendText(svm.CheckNumber == null ? "" : svm.CheckNumber);
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Transamt.ToString());
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.NationalFees.ToString());
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Vat.ToString());

                            }
                            break;
                        }
                    case 7:
                        {
                            IWSection section = document.AddSection();
                            section.AddParagraph().AppendText("VAT on Transaction Charge");
                            section.AddParagraph().AppendText($"Branch: {Extensions.GetEnumDisplayName((BranchName)record.Branch)}");
                            section.AddParagraph().AppendText($"Report: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}");
                            section.AddParagraph().AppendText($"StartDate: {record.dateFrom.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph().AppendText($"EndDate:{record.DateTo.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph();
                            //Adds a new table into Word document
                            IWTable table = section.AddTable();
                            //Adds the first row into table
                            WTableRow row = table.AddRow();
                            //Adds the first cell into first row 
                            WTableCell cell = row.AddCell();

                            cell.Width = 55;
                            cell.AddParagraph().AppendText("VAT");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 100;
                            cell.AddParagraph().AppendText("National Fees");
                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("SubTotal");
                            //Adds the second cell into first row 

                            //Adds the second cell into first row 
                            foreach (var item in result)
                            {
                                VATOnTransactionCharge_VM svm = new VATOnTransactionCharge_VM();
                                svm = (VATOnTransactionCharge_VM)item;
                                row = table.AddRow(true, false);
                                //Adds the first cell into second row
                                cell = row.AddCell();
                                cell.Width = 55;
                                cell.AddParagraph().AppendText(svm.VAT.ToString());
                                cell = row.AddCell();
                                cell.Width = 100;
                                cell.AddParagraph().AppendText(svm.National_Fees.ToString());
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Total.ToString());
                            }
                            table.TableFormat.IsAutoResized = true;
                            table.ApplyStyle(BuiltinTableStyle.MediumShading1Accent1);
                            break;
                        }
                    case 8:
                        {
                            IWSection section = document.AddSection();
                            section.AddParagraph().AppendText("VAT on Fraud Charge");
                            section.AddParagraph().AppendText($"Branch: {Extensions.GetEnumDisplayName((BranchName)record.Branch)}");
                            section.AddParagraph().AppendText($"Report: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}");
                            section.AddParagraph().AppendText($"StartDate: {record.dateFrom.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph().AppendText($"EndDate:{record.DateTo.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph();
                            //Adds a new table into Word document
                            IWTable table = section.AddTable();
                            //Adds the first row into table
                            WTableRow row = table.AddRow();
                            //Adds the first cell into first row 
                            WTableCell cell = row.AddCell();

                            cell.Width = 55;
                            cell.AddParagraph().AppendText("Total VAT");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 100;
                            cell.AddParagraph().AppendText("Total Net Fees");
                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Grand Total");
                            //Adds the second cell into first row 

                            //Adds the second cell into first row 
                            foreach (var item in result)
                            {
                                VATOnTransactionCharge_VM svm = new VATOnTransactionCharge_VM();
                                svm = (VATOnTransactionCharge_VM)item;
                                row = table.AddRow(true, false);
                                //Adds the first cell into second row
                                cell = row.AddCell();
                                cell.Width = 55;
                                cell.AddParagraph().AppendText(svm.VAT.ToString());
                                cell = row.AddCell();
                                cell.Width = 100;
                                cell.AddParagraph().AppendText(svm.National_Fees.ToString());
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Total.ToString());
                            }
                            table.TableFormat.IsAutoResized = true;
                            table.ApplyStyle(BuiltinTableStyle.MediumShading1Accent1);
                            break;
                        }
                }
            }
            using (var memoryStream = new MemoryStream())
            {

                if (doctype == 2)
                {
                    doc.Save(memoryStream);
                    memoryStream.Position = 0;
                    doc.Close(true);
                    var content = memoryStream.ToArray();
                    var contentType = "application/pdf";
                    //downloadFileName = "Output.pdf";
                    switch (report)
                    {
                        case 1:
                            {
                                downloadFileName = "summaryReport.pdf";

                                break;
                            }
                        case 2:
                            {
                                downloadFileName = "ddascRpt.pdf";

                                break;
                            }
                        case 3:
                            {
                                downloadFileName = "loanChrgsRpt.pdf";

                                break;
                            }
                        case 4:
                            {
                                downloadFileName = "stopPayBrRpt.pdf";
                                break;
                            }
                        case 5:
                            {
                                downloadFileName = "transChrgRpt.pdf";
                                break;
                            }
                        case 6:
                            {
                                downloadFileName = "safeKeepBrRpt.pdf";
                                break;
                            }
                        case 7:
                            {
                                downloadFileName = "vatOnFraudChargeRpt.pdf";
                                break;
                            }
                        case 8:
                            {
                                downloadFileName = "vatOnTransChargeRpt.pdf";
                                break;
                            }
                    }
                    return File(content, contentType, downloadFileName);
                }
                else if (doctype == 1)
                {
                    excel.SaveAs(memoryStream);
                    var content = memoryStream.ToArray();
                    var contentType = "application/octet-stream";
                    switch (report)
                    {
                        case 1:
                            {
                                downloadFileName = "summaryReport.xlsx";

                                break;
                            }
                        case 2:
                            {
                                downloadFileName = "ddascRpt.xlsx";

                                break;
                            }
                        case 3:
                            {
                                downloadFileName = "loanChrgsRpt.xlsx";

                                break;
                            }
                        case 4:
                            {
                                downloadFileName = "stopPayBrRpt.xlsx";
                                break;
                            }
                        case 5:
                            {
                                downloadFileName = "transChrgRpt.xlsx";
                                break;
                            }
                        case 6:
                            {
                                downloadFileName = "safeKeepBrRpt.xlsx";
                                break;
                            }
                        case 7:
                            {
                                downloadFileName = "vatOnFraudChargeRpt.xlsx";
                                break;
                            }
                        case 8:
                            {
                                downloadFileName = "vatOnTransChargeRpt.xlsx";
                                break;
                            }
                    }
                    return File(content, contentType, downloadFileName);
                }
                else
                {
                    MemoryStream stream = new MemoryStream();
                    document.Save(stream, FormatType.Docx);
                    //Closes the document
                    document.Close();
                    stream.Position = 0;
                    //Download Word document in the browser

                    string fileName = "";
                    switch (report)
                    {
                        case 1:
                            {
                                fileName = "summaryReport.docx";

                                break;
                            }
                        case 2:
                            {
                                fileName = "ddascRpt.docx";

                                break;
                            }
                        case 3:
                            {
                                fileName = "loanChrgsRpt.docx";

                                break;
                            }
                        case 4:
                            {
                                fileName = "stopPayBrRpt.docx";
                                break;
                            }
                        case 5:
                            {
                                fileName = "transChrgRpt.docx";
                                break;
                            }
                        case 6:
                            {
                                fileName = "safeKeepBrRpt.docx";
                                break;
                            }
                        case 7:
                            {
                                fileName = "vatOnFraudChargeRpt.docx";
                                break;
                            }
                        case 8:
                            {
                                fileName = "vatOnTransChargeRpt.docx";
                                break;
                            }
                    }
                    return File(stream, "application/msword", fileName);


                }
            }
        }
        public void printlog(string message)
        {
            string status = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["IsPrintLog"];
            if (status == "1")
            {
                EventLog.WriteEntry(".NET Runtime", message, EventLogEntryType.Warning, 1000);
            }
        }
    }
}
public enum BranchName
{
    [Display(Name = "Basseterre")]
    Basseterre = 0,
    [Display(Name = "Nevis")]
    Nevis = 1,
    [Display(Name = "Pelican Mail")]
    PelicanMail = 4,
    [Display(Name = "Sandy Point")]
    SandyPoint = 2
}

public enum ReportsName
{
    [Display(Name = "Standing Orders")]
    StandingOrders = 1,
    [Display(Name = "DDA Service Charge")]
    DDAServiceCharge = 2,
    [Display(Name = "Late Charges Report")]
    LateChargesReport = 3,
    [Display(Name = "Stop Pay Charges")]
    StopPayCharges = 4,
    [Display(Name = "Transfer Charges")]
    TransferCharges = 5,
    [Display(Name = "Safekeeping Charges")]
    SafekeepingCharges = 6,
    [Display(Name = "VAT On Fraud Charges")]
    VATOnFraudCharges = 7,
    [Display(Name = "VAT On Transaction Charge")]
    VATOnTransactionCharge = 8
}

public static class Extensions
{
    public static string GetEnumDisplayName(this Enum value)
    {
        FieldInfo fi = value.GetType().GetField(value.ToString());

        DisplayAttribute[] attributes = (DisplayAttribute[])fi.GetCustomAttributes(typeof(DisplayAttribute), false);

        if (attributes != null && attributes.Length > 0)
            return attributes[0].Name;
        else
            return value.ToString();
    }
}




