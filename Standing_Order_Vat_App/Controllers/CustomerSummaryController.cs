//using iTextSharp.text;
//using iTextSharp.text.pdf;

using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.MvcHelper;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Grid;
using System.Data;
using System.Diagnostics;

using System;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Net.Mail;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Standing_Order_Vat_App.Controllers
{
    public class CustomerSummaryController : Controller
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
        private readonly ICustomerdetail customerdetail;
        public CustomerSummaryController(IUserRole userRoleService, IgetSummary summaryrecordservices, IGetDDACReport getDDACReportservice,
        IGetLoanCharge getLoanChargeservice, IStopPayCharge getstopPayChargeservice, ITansChargeBranch getTansChargeBranchservise
        , ISafekeepingPayments getSafekeepingPayments, ICustomerdetail customerdetail)
        {
            this.userRoleService = userRoleService;
            this.summaryrecordservices = summaryrecordservices;
            this.getDDACReportservice = getDDACReportservice;
            this.getLoanChargeservice = getLoanChargeservice;
            this.getstopPayChargeservice = getstopPayChargeservice;
            this.getTansChargeBranchservise = getTansChargeBranchservise;
            this.getSafekeepingPayments = getSafekeepingPayments;
            this.customerdetail = customerdetail;
        }
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public IActionResult CustomerSummaryReport(CustomerSummary_VM obj, int pn = 1, int recordPerPage = 10, int customer = 0, int report = 0, DateTime Startdate = default, DateTime Enddate = default, string search = "")
        {

            printlog("Status: Application Start");

            CustomerSummary_VM record = new CustomerSummary_VM();
            List<UserRole_VM> userRolelist = new List<UserRole_VM>();
            record.Customersacc = obj.Customersacc;

            if (!string.IsNullOrEmpty(HttpContext.Request.Query["Startdate"]) && !string.IsNullOrEmpty(HttpContext.Request.Query["Enddate"]))
            {
                obj.Startdate = Convert.ToDateTime(HttpContext.Request.Query["Startdate"]);
                obj.Enddate = Convert.ToDateTime(HttpContext.Request.Query["Enddate"]);
            }
            DateTime dt = new DateTime();


            if (Startdate != dt)
            {
                // obj.Customers.FirstOrDefault().Customer = customer.ToString();
                obj.Report = report;
                obj.Startdate = Startdate;
                obj.Enddate = Enddate;

            }
            obj.search = search;
            ViewBag.pageno = pn;

            var rec = userRoleService.GetUserRole(User.Identity.Name);
            userRolelist = rec.Select(x => ((UserRole_VM)x)).ToList();

            printlog("User List Count: " + userRolelist.Count.ToString());

            printlog("User Name: " + User.Identity.Name);
            printlog("App Name: NB_VAT_FEES");

            record.UserRole_VMs = userRolelist;
            List<Customer_VM> customers = new List<Customer_VM>();
            ViewBag.ddlrec = customers;
            ViewBag.ControllerName = "CustomerSummaryReport";
            HttpContext.Session.SetString(Sessionusercount, userRolelist.Count.ToString());
            if (userRolelist.Count() > 0)
            {


                HttpContext.Session.SetInt32(Sessionuid, Convert.ToInt32(userRolelist.FirstOrDefault().RoleID));
                printlog("Role ID: " + userRolelist.FirstOrDefault().RoleID.ToString());

                HttpContext.Session.SetString(Sessionuname, userRolelist.FirstOrDefault().UserName);
                printlog("User Name: " + userRolelist.FirstOrDefault().UserName.ToString());

                HttpContext.Session.SetString(Sessionurole, userRolelist.FirstOrDefault().RoleName);
                printlog("User Role Name: " + userRolelist.FirstOrDefault().RoleName.ToString());

                customers = customerdetail.GetCustomerDetail(obj.Report);
                ViewBag.ddlrec = customers;
                ViewBag.ControllerName = "CustomerSummaryReport";
                long TotalRecord = 0;
                switch (obj.Report)
                {
                    case 1:
                        {
                            record.acct = obj.acct;
                            if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                            {
                                ViewBag.Message = String.Format("You are not authorized to view this report");
                            }
                            else
                            {
                                record.Report = 1;
                                record.StandingOrder = summaryrecordservices.GetCustomerDetail(obj, pn - 1, recordPerPage);
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
                            record.acct = obj.acct;

                            if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                            {
                                ViewBag.Message = String.Format("You are not authorized to view this report");
                            }
                            else
                            {
                                record.Report = 2;
                                record.DDASCReport_VMs = getDDACReportservice.GetCustomerDDASCReport(obj, pn - 1, recordPerPage);
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
                            record.acct = obj.acct;
                            record.Report = 3;

                            if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Main Branch")
                            {
                                ViewBag.Message = String.Format("You are not authorized to view this report");
                            }
                            else if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit" |
                                HttpContext.Session.GetString(Sessionurole)?.ToString() == "Sandy Point" |
                                HttpContext.Session.GetString(Sessionurole)?.ToString() == "Saddlers" |
                                HttpContext.Session.GetString(Sessionurole)?.ToString() == "Pelican Mall" |
                                HttpContext.Session.GetString(Sessionurole)?.ToString() == "NB Nevis" |
                                HttpContext.Session.GetString(Sessionurole)?.ToString() == "Manager")
                            {
                                record.Report = 3;
                                record.LoanCharge_VMs = getLoanChargeservice.GetCustomerLoanCharge(obj, pn - 1, recordPerPage);
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
                            record.acct = obj.acct;
                            record.Report = 4;

                            if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                            {
                                ViewBag.Message = String.Format("You are not authorized to view this report");
                            }
                            else
                            {
                                record.Report = 4;
                                record.StopPayCharge_VMs = getstopPayChargeservice.GetCustomerStopPayCharge(obj, pn - 1, recordPerPage);
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
                            record.acct = obj.acct;
                            record.Report = 5;

                            if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                            {
                                ViewBag.Message = String.Format("You are not authorized to view this report");
                            }
                            else
                            {
                                record.Report = 5;
                                record.TansChargeBranch_VMs = getTansChargeBranchservise.GetCustomerTansChargeBranch(obj, pn - 1, recordPerPage);
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
                            record.acct = obj.acct;
                            record.Report = 6;

                            if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                            {
                                ViewBag.Message = String.Format("You are not authorized to view this report");
                            }
                            else
                            {
                                record.Report = 6;
                                record.SafekeepingPayment_VMs = getSafekeepingPayments.getCustomerSafekeepingPayments(obj, pn - 1, recordPerPage);
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
                }

                record.Startdate = obj.Startdate;
                record.Enddate = obj.Enddate;
                record.acct = obj.acct;
                record.search = obj.search;
                if (record.Customers != null)
                {
                    record.Customers.FirstOrDefault().Customer = obj.Customers.ToString();
                }
                ViewData["Paging"] = PaginationView.Set_Paging_Customer(pn, recordPerPage, TotalRecord, "active", Url.Action("CustomerSummaryReport"), "disableLink", record.acct, record.Report, record.Startdate, record.Enddate, record.search);
                ModelState.Clear();
            }
            else
            {
                ViewBag.Message = String.Format(User.Identity.Name.ToString() + " is not registered. please contact to the Admin");
            }
            return View(record);
        }
        [HttpPost]

        public JsonResult GetCustomer(int reportid)
        {
            List<Customer_VM> customers = new List<Customer_VM>();

            if (string.IsNullOrEmpty(HttpContext.Session.GetString(Sessionurole)?.ToString()) == false)
            {
                customers = customerdetail.GetCustomerDetail(reportid);
                ViewBag.ddlrec = customers;
            }
            return Json(customers);

        }

        [HttpGet]
        public async Task<IActionResult> ExportListUsingEPPlus(int pn = 1, int recordPerPage = 10, int brchno = 0, int report = 0, DateTime fdate = default, DateTime tdate = default, int doctype = 3, string search = "")
        {
            CustomerSummary_VM record = new CustomerSummary_VM();
            ulong TotalRecord = 0;
            record.acct = brchno;
            record.Report = report;
            record.Startdate = fdate;
            record.Enddate = tdate;
            record.search = search;
            dynamic result = record;
            string downloadFileName = "";

            var customers = customerdetail.GetCustomerDetail(record.Report);

            if (!string.IsNullOrEmpty(HttpContext.Request.Query["fdate"]) && !string.IsNullOrEmpty(HttpContext.Request.Query["tdate"]))
            {
                record.Startdate = Convert.ToDateTime(HttpContext.Request.Query["fdate"]);
                record.Enddate = Convert.ToDateTime(HttpContext.Request.Query["tdate"]);
            }
            switch (report)
            {
                case 1:
                    {
                        //record.acct = ;
                        if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                        {
                            ViewBag.Message = String.Format("You are not authorized to view this report");
                        }
                        else
                        {
                            record.Report = 1;
                            result = summaryrecordservices.GetCustomerDetailDawnload(record);

                        }
                        break;
                    }
                case 2:
                    {
                        //  record.acct = obj.acct;

                        if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                        {
                            ViewBag.Message = String.Format("You are not authorized to view this report");
                        }
                        else
                        {
                            record.Report = 2;
                            result = getDDACReportservice.GetCustomerDDASCReportDawnload(record);

                        }
                        break;
                    }
                case 3:
                    {
                        //  record.acct = obj.acct;

                        if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Main Branch")
                        {
                            ViewBag.Message = String.Format("You are not authorized to view this report");
                        }
                        else if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit" |
                            HttpContext.Session.GetString(Sessionurole)?.ToString() == "Sandy Point" |
                            HttpContext.Session.GetString(Sessionurole)?.ToString() == "Saddlers" |
                            HttpContext.Session.GetString(Sessionurole)?.ToString() == "Pelican Mall" |
                            HttpContext.Session.GetString(Sessionurole)?.ToString() == "NB Nevis" |
                            HttpContext.Session.GetString(Sessionurole)?.ToString() == "Manager")
                        {
                            record.Report = 3;
                            result = getLoanChargeservice.GetCustomerLoanChargeDawnload(record);
                        }
                        break;
                    }

                case 4:
                    {
                        // record.acct = obj.acct;

                        if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                        {
                            ViewBag.Message = String.Format("You are not authorized to view this report");
                        }
                        else
                        {
                            record.Report = 4;
                            result = getstopPayChargeservice.GetCustomerStopPayChargeDawnload(record);
                        }
                        break;
                    }
                case 5:
                    {
                        // record.acct = obj.acct;

                        if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                        {
                            ViewBag.Message = String.Format("You are not authorized to view this report");
                        }
                        else
                        {
                            record.Report = 5;
                            result = getTansChargeBranchservise.GetCustomerTansChargeBranchDawnload(record);
                        }
                        break;
                    }
                case 6:
                    {
                        // record.acct = obj.acct;

                        if (HttpContext.Session.GetString(Sessionurole)?.ToString() == "Credit")
                        {
                            ViewBag.Message = String.Format("You are not authorized to view this report");
                        }
                        else
                        {
                            record.Report = 6;
                            result = getSafekeepingPayments.getCustomerSafekeepingPaymentsDawnload(record);
                        }
                        break;
                    }
            }
            //  record.StandingOrder = summaryrecordservices.GetSummaryReport(record);
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Sheet1");


            //workSheet.Cells[1, 1].Value = $"";

            workSheet.Cells[1, 1].Value = $"CustomerName: {customers.Where(w => w.Acct == record.acct.ToString()).Select(s => s.CustomerName).FirstOrDefault()}";
            workSheet.Cells[2, 1].Value = $"Branch:Report: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}";
            workSheet.Cells[3, 1].Value = $"DateFrom: {record.Startdate.Date.ToString("MM/dd/yyyy")}";
            workSheet.Cells[4, 1].Value = $"DateTo: {record.Enddate.Date.ToString("MM/dd/yyyy")}";
            workSheet.Cells[6, 1].LoadFromCollection(result, true);

            // pdf maker
            PdfDocument doc = new PdfDocument();
            //Add a page.
            PdfPage page = doc.Pages.Add();
            //Create a PdfGrid.
            PdfGrid pdfGrid = new PdfGrid();
            if (doctype == 2)
            {
                pdfGrid.DataSource = result;
                //Draw grid to the page of PDF document.

                pdfGrid.Draw(page, new Syncfusion.Drawing.PointF(0, 200));

                PdfPageBase page1 = doc.Pages[0] as PdfPageBase;
                PdfGraphics graphics = page.Graphics;
                //GAurav


                FileStream imageStream = System.IO.File.Open(@"wwwroot\Image\vat.jpg", FileMode.Open, FileAccess.Read, FileShare.None);
                PdfBitmap image = new PdfBitmap(imageStream);
                //Set layout property to make the element break across the pages
                PdfLayoutFormat format = new PdfLayoutFormat();
                format.Break = PdfLayoutBreakType.FitPage;
                format.Layout = PdfLayoutType.Paginate;
                //Draw image
                image.Draw(page, 0, 0, format);
                PdfFont graphicFont = new PdfStandardFont(PdfFontFamily.Helvetica, 10);


                graphics.DrawString($"CustomerName: {customers.Where(w => w.Acct == record.acct.ToString()).Select(s => s.CustomerName).FirstOrDefault()}\nBranch:Report: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}\nDateFrom: {record.Startdate.Date.ToString("MM/dd/yyyy")}\nDateTo: {record.Enddate.Date.ToString("MM/dd/yyyy")}", graphicFont, PdfBrushes.Black, new PointF(10, 130));

                //pdfGrid.Draw(page, new Syncfusion.Drawing.PointF(10, 10));
            }

            WordDocument document = new WordDocument();
            if (doctype == 3)
            {
                switch (report)
                {
                    case 1:
                        {
                            IWSection section = document.AddSection();
                            section.AddParagraph().AppendText("Standing Orders Customer Report");

                            //Draw grid to the page of PDF document.
                            pdfGrid.Draw(page, new Syncfusion.Drawing.PointF(10, 80));
                            PdfPageBase page1 = doc.Pages[0] as PdfPageBase;
                            PdfGraphics graphics = page.Graphics;
                            PdfFont graphicFont = new PdfStandardFont(PdfFontFamily.Helvetica, 10);
                            graphics.DrawString($"CustomerName: {customers.Where(w => w.Acct == record.acct.ToString()).Select(s => s.CustomerName).FirstOrDefault()}\nReport: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}\nStartDate: {record.Startdate.Date.ToString("MM/dd/yyyy")}\nEndDate: {record.Enddate.Date.ToString("MM/dd/yyyy")}", graphicFont, PdfBrushes.Black, new PointF(10, 10));

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

                            cell.Width = 100;
                            cell.AddParagraph().AppendText("Date");
                            cell = row.AddCell();

                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Account");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Customer Name");

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
                                cell.Width = 100;
                                cell.AddParagraph().AppendText(svm.DateActive == null ? "" : svm.DateActive);
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Acct == null ? "" : svm.Acct);

                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.CustomerName == null ? "" : svm.CustomerName);

                                cell = row.AddCell();
                                cell.Width = 70;
                                cell.AddParagraph().AppendText(svm.OffsetAcctNumber);
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

                            string dataPath = @"E:\GGGGG\Standing_Order_Vat_App\Word\OleTemplate.docx";
                            //FileStream fileStream1 = System.IO.File.Open(dataPath, FileMode.Open,
                            //FileAccess.Read, FileShare.None);

                            //FileStream fileStream = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);


                            section.AddParagraph().ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

                            FileStream imageStream = System.IO.File.Open(@"wwwroot\Image\vatq.jpg", FileMode.Open, FileAccess.Read, FileShare.None);
                            WPicture picture = (WPicture)section.AddParagraph().AppendPicture(imageStream);

                            picture.AddCaption("Figure", CaptionNumberingFormat.Roman, CaptionPosition.AfterImage);
                            ApplyFormattingForCaption(document.LastParagraph);



                            //IWPicture iWPicture = section.AddParagraph().AppendPicture("..Image//vat.jpg");
                            section.AddParagraph().AppendText("DDA Service Charge Customer Report");
                            WTextBody body;
                            section.AddParagraph().AppendText($"CustomerName: {customers.Where(w => w.Acct == record.acct.ToString()).Select(s => s.CustomerName).FirstOrDefault()}");
                            section.AddParagraph().AppendText($"Branch:Report: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}");
                            section.AddParagraph().AppendText($"Date From: {record.Startdate.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph().AppendText($"Date To: {record.Enddate.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph();

                            //IWTable table1 = section.AddTable();
                            //WTableRow row2 = table1.AddRow();



                            section.AddParagraph().AppendText($"{Extensions.GetEnumDisplayName((ReportsName)record.Report)}" + "  & VAT Summary");




                            //Adds a new table into Word document

                            IWTable table = section.AddTable();



                            //Adds the first row into table
                            WTableRow row = table.AddRow();
                            //Adds the first cell into first row 
                            WTableCell cell = row.AddCell();

                            cell.Width = 55;
                            cell.AddParagraph().AppendText("Branch");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

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
                                cell.AddParagraph().AppendText(svm.Branch_number == null ? "" : svm.Branch_number);
                                cell = row.AddCell();
                                cell.Width = 55;
                                cell.AddParagraph().AppendText(svm.ACCT == null ? "" : svm.ACCT);
                                cell = row.AddCell();
                                cell.Width = 100;
                                cell.AddParagraph().AppendText(svm.Customer_Name);
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
                            section.AddParagraph().AppendText("Loan Customer Late Charge Summary Report");

                            section.AddParagraph().AppendText($"CustomerName: {customers.Where(w => w.Acct == record.acct.ToString()).Select(s => s.CustomerName).FirstOrDefault()}");
                            section.AddParagraph().AppendText($"Report: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}");
                            section.AddParagraph().AppendText($"StartDate: {record.Startdate.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph().AppendText($"EndDate: {record.Enddate.Date.ToString("MM/dd/yyyy")}");

                            section.AddParagraph();
                            //Adds a new table into Word document
                            IWTable table = section.AddTable();
                            //Adds the first row into table
                            WTableRow row = table.AddRow();
                            //Adds the first cell into first row 
                            WTableCell cell = row.AddCell();

                            cell.Width = 55;
                            cell.AddParagraph().AppendText("Branch");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 100;
                            cell.AddParagraph().AppendText("Account");
                            cell = row.AddCell();

                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Customer Name");

                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Date");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 70;
                            cell.AddParagraph().AppendText("Total fees");

                            cell = row.AddCell();
                            cell.Width = 50;
                            cell.AddParagraph().AppendText("National fees");

                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Vat");

                            //Adds the second cell into first row 
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
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Dateactive == null ? "" : svm.Dateactive);
                                cell = row.AddCell();
                                cell.Width = 70;
                                cell.AddParagraph().AppendText(svm.Totalfees.ToString());
                                cell = row.AddCell();
                                cell.Width = 50;
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
                            section.AddParagraph().AppendText("Stop Pay Customer report");

                            section.AddParagraph().AppendText($"CustomerName: {customers.Where(w => w.Acct == record.acct.ToString()).Select(s => s.CustomerName).FirstOrDefault()}");
                            section.AddParagraph().AppendText($"Report: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}");
                            section.AddParagraph().AppendText($"StartDate: {record.Startdate.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph().AppendText($"EndDate: {record.Enddate.Date.ToString("MM/dd/yyyy")}");

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

                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Customer Name");

                            cell.Width = 70;
                            cell.AddParagraph().AppendText("Branch");

                            cell = row.AddCell();
                            cell.Width = 50;
                            cell.AddParagraph().AppendText("Prof of Sequence");

                            //Adds the second cell into first row 
                            cell = row.AddCell();
                            cell.Width = 100;
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
                                cell.AddParagraph().AppendText(svm.Branch == null ? "" : svm.Branch);
                                cell = row.AddCell();
                                cell.Width = 50;
                                cell.AddParagraph().AppendText(svm.ProofSequence == null ? "" : svm.ProofSequence);
                                cell = row.AddCell();
                                cell.Width = 100;
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

                            section.AddParagraph().AppendText($"CustomerName: {customers.Where(w => w.Acct == record.acct.ToString()).Select(s => s.CustomerName).FirstOrDefault()}");
                            section.AddParagraph().AppendText($"Report: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}");
                            section.AddParagraph().AppendText($"Date From: {record.Startdate.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph().AppendText($"Date To: {record.Enddate.Date.ToString("MM/dd/yyyy")}");

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

                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Customer Name");

                            cell.Width = 100;
                            cell.AddParagraph().AppendText("Date");
                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Branch");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 70;
                            cell.AddParagraph().AppendText("Proof Sequence");

                            cell = row.AddCell();
                            cell.Width = 50;
                            cell.AddParagraph().AppendText("Check Number");

                            //Adds the second cell into first row 
                            cell = row.AddCell();
                            cell.Width = 50;
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
                                TansChargeBranch_VM_Download svm = new TansChargeBranch_VM_Download();
                                svm = (TansChargeBranch_VM_Download)item;
                                row = table.AddRow(true, false);
                                //Adds the first cell into second row
                                cell = row.AddCell();
                                cell.Width = 55;
                                cell.AddParagraph().AppendText(svm.Acct == null ? "" : svm.Acct);
                                cell = row.AddCell();
                                cell.Width = 100;
                                cell.AddParagraph().AppendText(svm.Dateactive == null ? "" : svm.Dateactive);
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Branch == null ? "" : svm.Branch);
                                cell = row.AddCell();
                                cell.Width = 70;
                                cell.AddParagraph().AppendText(svm.ProffSequence == null ? "" : svm.ProffSequence);
                                cell = row.AddCell();
                                cell.Width = 50;
                                cell.AddParagraph().AppendText(svm.CheckNumber.ToString());
                                cell = row.AddCell();
                                cell.Width = 50;
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
                    case 6:
                        {
                            IWSection section = document.AddSection();
                            section.AddParagraph().AppendText("Safe Keeping Charge Report Summary");

                            section.AddParagraph().AppendText($"CustomerName: {customers.Where(w => w.Acct == record.acct.ToString()).Select(s => s.CustomerName).FirstOrDefault()}");
                            section.AddParagraph().AppendText($"Report: {Extensions.GetEnumDisplayName((ReportsName)record.Report)}");
                            section.AddParagraph().AppendText($"Date From: {record.Startdate.Date.ToString("MM/dd/yyyy")}");
                            section.AddParagraph().AppendText($"Date To: {record.Enddate.Date.ToString("MM/dd/yyyy")}");

                            section.AddParagraph();
                            //Adds a new table into Word document
                            IWTable table = section.AddTable();
                            //Adds the first row into table
                            WTableRow row = table.AddRow();
                            //Adds the first cell into first row 
                            WTableCell cell = row.AddCell();

                            cell.Width = 55;
                            cell.AddParagraph().AppendText("CIF");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell.Width = 100;
                            cell.AddParagraph().AppendText("Account");
                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Date");
                            //Adds the second cell into first row 
                            cell = row.AddCell();

                            cell = row.AddCell();
                            cell.Width = 60;
                            cell.AddParagraph().AppendText("Customer Name");

                            cell.Width = 70;
                            cell.AddParagraph().AppendText("Branch");

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
                                cell.AddParagraph().AppendText(svm.Cif == null ? "" : svm.Cif.ToString());
                                cell = row.AddCell();
                                cell.Width = 100;
                                cell.AddParagraph().AppendText(svm.Acct == null ? "" : svm.Acct.ToString());
                                cell = row.AddCell();
                                cell.Width = 60;
                                cell.AddParagraph().AppendText(svm.Dateactive == null ? "" : svm.Dateactive);
                                cell = row.AddCell();
                                cell.Width = 70;
                                cell.AddParagraph().AppendText(svm.Branch == null ? "" : svm.Branch);
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
                    switch (report)
                    {
                        case 1:
                            {
                                downloadFileName = "cstrSOSummRpt.pdf";
                                break;
                            }
                        case 2:
                            {
                                downloadFileName = "cstrDDARpt.pdf";
                                break;
                            }
                        case 3:
                            {
                                downloadFileName = "cstrLoanAcctRpt.pdf";
                                break;
                            }
                        case 4:
                            {
                                downloadFileName = "cstrStopPayRpt.pdf";
                                break;
                            }
                        case 5:
                            {
                                downloadFileName = "cstrTranfChrgRpt.pdf";
                                break;
                            }
                        case 6:
                            {
                                downloadFileName = "cstrSafeKeepingRpt.pdf";
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
                                downloadFileName = "cstrSOSummRpt.xlsx";
                                break;
                            }
                        case 2:
                            {
                                downloadFileName = "cstrDDARpt.xlsx";
                                break;
                            }
                        case 3:
                            {
                                downloadFileName = "cstrLoanAcctRpt.xlsx";
                                break;
                            }
                        case 4:
                            {
                                downloadFileName = "cstrStopPayRpt.xlsx";
                                break;
                            }
                        case 5:
                            {
                                downloadFileName = "cstrTranfChrgRpt.xlsx";
                                break;
                            }
                        case 6:
                            {
                                downloadFileName = "cstrSafeKeepingRpt.xlsx";
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

                    switch (report)
                    {
                        case 1:
                            {
                                downloadFileName = "cstrSOSummRpt.docx";
                                break;
                            }
                        case 2:
                            {
                                downloadFileName = "cstrDDARpt.docx";
                                break;
                            }
                        case 3:
                            {
                                downloadFileName = "cstrLoanAcctRpt.docx";
                                break;
                            }
                        case 4:
                            {
                                downloadFileName = "cstrStopPayRpt.docx";
                                break;
                            }
                        case 5:
                            {
                                downloadFileName = "cstrTranfChrgRpt.docx";
                                break;
                            }
                        case 6:
                            {
                                downloadFileName = "cstrSafeKeepingRpt.docx";
                                break;
                            }

                    }
                    return File(stream, "application/msword", downloadFileName);
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
        private void ApplyFormattingForCaption(WParagraph paragraph)
        {
            //Align the caption
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            //Sets after spacing
            paragraph.ParagraphFormat.AfterSpacing = 1.5f;
            //Sets before spacing
            paragraph.ParagraphFormat.BeforeSpacing = 1.5f;
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

}
