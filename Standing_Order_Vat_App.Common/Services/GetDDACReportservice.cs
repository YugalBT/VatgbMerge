using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB;
using System.Linq;
using System.Runtime.InteropServices;

namespace Standing_Order_Vat_App.Common.Services
{
    public class GetDDACReportservice : IGetDDACReport
    {
        private readonly Standing_Order_VATContext standing_Order_VATContext;

        public GetDDACReportservice(Standing_Order_VATContext standing_Order_VATContext)
        {
            this.standing_Order_VATContext = standing_Order_VATContext;
        }


        public List<DDASCReport_VM> GetCustomerDDASCReport(CustomerSummary_VM customerSummary_VM, [Optional] int pageNum, [Optional] int recordPerPage)
        {
            List<DDASCReport_VM> list = new List<DDASCReport_VM>();
            if (string.IsNullOrEmpty(customerSummary_VM.search) == true)
            {
                list = standing_Order_VATContext.Ddascjs.Where(w => w.Acct == customerSummary_VM.acct.ToString()
                && w.RptDate >= customerSummary_VM.Startdate && w.RptDate <= customerSummary_VM.Enddate && w.Charged != 0.00 && w.BranchNumber == "9")
                    .Select(s => new DDASCReport_VM
                    {
                        ACCT = s.Acct,
                        Branch_number = s.BranchNumber,
                        Charged = Convert.ToString(s.Charged),
                        Customer_Name = s.CustomerName,
                        DDASCJ_ID = s.DdascjId,
                        National_Fees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                        RptDate = s.RptDate,
                        VAT = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                    }).ToList();
                if (list.Count > 0)
                {
                    list.Add(new DDASCReport_VM
                    {
                        Customer_Name = "Totals:",
                        Charged = String.Format("{0:0.00}", list.Sum(s => Convert.ToDouble(s.Charged))),
                        //Charged = list.Sum(s => s.Charged),
                        National_Fees = String.Format("{0:0.00}", list.Sum(s => Convert.ToDouble(s.National_Fees))),
                        VAT = String.Format("{0:0.00}", list.Sum(s => Convert.ToDouble(s.VAT)))
                    });
                    list = list.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                    ulong totalcoutn = (ulong)standing_Order_VATContext.Ddascjs.Where(w => w.Acct == customerSummary_VM.acct.ToString()
                   && w.RptDate >= customerSummary_VM.Startdate && w.RptDate <= customerSummary_VM.Enddate && w.Charged != 0.00 && w.BranchNumber == "9").Count();
                    list.FirstOrDefault().TotalRecordCount = totalcoutn + 1;
                }
            }
            else
            {

                list = standing_Order_VATContext.Ddascjs.Where(w => w.Acct == customerSummary_VM.acct.ToString()
                && w.RptDate >= customerSummary_VM.Startdate && w.RptDate <= customerSummary_VM.Enddate && w.Charged != 0.00 && w.BranchNumber == "9"
                && (w.Acct.Contains(customerSummary_VM.search) || w.BranchNumber.Contains(customerSummary_VM.search) || w.Charged.ToString().Contains(customerSummary_VM.search)
                || w.CustomerName.Contains(customerSummary_VM.search) || w.NationalFees.ToString().Contains(customerSummary_VM.search) || w.RptDate.ToString().Contains(customerSummary_VM.search) ||
                w.Vat.ToString().Contains(customerSummary_VM.search)))
                                    .Select(s => new DDASCReport_VM
                                    {
                                        ACCT = s.Acct,
                                        Branch_number = s.BranchNumber,
                                        Charged = Convert.ToString(s.Charged),
                                        Customer_Name = s.CustomerName,
                                        DDASCJ_ID = s.DdascjId,
                                        National_Fees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                                        RptDate = s.RptDate,
                                        VAT = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                                    }).ToList();
                if (list.Count > 0)
                {
                    list.Add(new DDASCReport_VM
                    {
                        Customer_Name = "Totals:",
                        Charged = String.Format("{0:0.00}", list.Sum(s => Convert.ToDouble(s.Charged))),
                        National_Fees = String.Format("{0:0.00}", list.Sum(s => Convert.ToDouble(s.National_Fees))),
                        VAT = String.Format("{0:0.00}", list.Sum(s => Convert.ToDouble(s.VAT)))
                    });
                    list = list.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();

                    ulong totalcoutn = (ulong)standing_Order_VATContext.Ddascjs.Where(w => w.Acct == customerSummary_VM.acct.ToString()
                   && w.RptDate >= customerSummary_VM.Startdate && w.RptDate <= customerSummary_VM.Enddate && w.Charged != 0.00 && w.BranchNumber == "9" && (w.Acct.Contains(customerSummary_VM.search) ||
                   w.BranchNumber.Contains(customerSummary_VM.search) || w.Charged.ToString().Contains(customerSummary_VM.search)
                || w.CustomerName.Contains(customerSummary_VM.search) || w.NationalFees.ToString().Contains(customerSummary_VM.search)
                || w.RptDate.ToString().Contains(customerSummary_VM.search) || w.Vat.ToString().Contains(customerSummary_VM.search))).Count();
                    list.FirstOrDefault().TotalRecordCount = totalcoutn + 1;

                }
            }
            return list;
        }

        public List<DDASCReport_VM_Download> GetCustomerDDASCReportDawnload(CustomerSummary_VM customerSummary_VM)
        {
            List<DDASCReport_VM_Download> list = new List<DDASCReport_VM_Download>();
            if (string.IsNullOrEmpty(customerSummary_VM.search) == true)
            {
                list = standing_Order_VATContext.Ddascjs.Where(w => w.Acct == customerSummary_VM.acct.ToString()
                && w.RptDate >= customerSummary_VM.Startdate && w.RptDate <= customerSummary_VM.Enddate && w.Charged != 0.00 && w.BranchNumber == "9")
                    .Select(s => new DDASCReport_VM_Download
                    {
                        ACCT = s.Acct,
                        Branch_number = s.BranchNumber,
                        Charged = Convert.ToString(s.Charged),
                        Customer_Name = s.CustomerName,
                        DDASCJ_ID = s.DdascjId,
                        National_Fees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                        RptDate = s.RptDate.Value.ToString("MM/dd/yyyy"),
                        VAT = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                    }).ToList();
            }
            else
            {
                list = standing_Order_VATContext.Ddascjs.Where(w => w.Acct == customerSummary_VM.acct.ToString()
                && w.RptDate >= customerSummary_VM.Startdate && w.RptDate <= customerSummary_VM.Enddate && w.Charged != 0.00 && w.BranchNumber == "9"
                && (w.Acct.Contains(customerSummary_VM.search) || w.BranchNumber.Contains(customerSummary_VM.search) ||
                w.Charged.ToString().Contains(customerSummary_VM.search)
                || w.CustomerName.Contains(customerSummary_VM.search) || w.NationalFees.ToString().Contains(customerSummary_VM.search) ||
                w.RptDate.ToString().Contains(customerSummary_VM.search) ||
                w.Vat.ToString().Contains(customerSummary_VM.search)))
                    .Select(s => new DDASCReport_VM_Download
                    {
                        ACCT = s.Acct,
                        Branch_number = s.BranchNumber,
                        Charged = Convert.ToString(s.Charged),
                        Customer_Name = s.CustomerName,
                        DDASCJ_ID = s.DdascjId,
                        National_Fees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                        RptDate = s.RptDate.Value.ToString("MM/dd/yyyy"),
                        VAT = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                    }).ToList();
            }
            if (list.Count > 0)
            {
                list.Add(new DDASCReport_VM_Download
                {
                    Customer_Name = "Totals:",
                    //String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Totalfees)))
                    Charged = String.Format("{0:0.00}", list.Sum(s => Convert.ToDouble(s.Charged))),
                    National_Fees = String.Format("{0:0.00}", list.Sum(s => Convert.ToDouble(s.National_Fees))),
                    VAT = String.Format("{0:0.00}", list.Sum(s => Convert.ToDouble(s.VAT))),
                });
                //ulong totalcoutn = (ulong)list.Count();
                //list.FirstOrDefault().TotalRecordCount = totalcoutn;
            }
            return list;
        }
        public List<DDASCReport_VM> GetDDASCReport(Summery_VM summery_VM, [Optional] int pageNum, [Optional] int recordPerPage)
        {
            List<DDASCReport_VM> list = new List<DDASCReport_VM>();
            if (string.IsNullOrEmpty(summery_VM.search) == true)
            {
                list = standing_Order_VATContext.Ddascjs.Where(w => w.BranchNumber == summery_VM.Branch.ToString()
                  && w.RptDate >= summery_VM.dateFrom && w.RptDate <= summery_VM.DateTo && w.Charged != 0.00).Select(s => new DDASCReport_VM
                  {
                      ACCT = s.Acct,
                      Branch_number = s.BranchNumber,
                      Charged = Convert.ToString(s.Charged),
                      Customer_Name = s.CustomerName,
                      RptDate = s.RptDate,
                      DDASCJ_ID = s.DdascjId,
                      National_Fees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                      VAT = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                  }).ToList();
                if (list.Count > 0)
                {
                    list.Add(new DDASCReport_VM
                    {
                        Customer_Name = "Totals: ",
                        // String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Totalfees)))
                        Charged = String.Format("{0:0.00}", list.Select(s => Convert.ToDouble(s.Charged)).ToList().Sum()),
                        VAT = String.Format("{0:0.00}", list.Select(s => Convert.ToDouble(s.VAT)).ToList().Sum()),
                        National_Fees = String.Format("{0:0.00}", list.Select(s => Convert.ToDouble(s.National_Fees)).ToList().Sum()),
                    });
                    list = list.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                }
            }
            else
            {
                list = standing_Order_VATContext.Ddascjs.Where(w => w.BranchNumber == summery_VM.Branch.ToString()
                  && w.RptDate >= summery_VM.dateFrom && w.RptDate <= summery_VM.DateTo && w.Charged != 0.00
                  && (w.Acct.Contains(summery_VM.search) ||
                  w.CustomerName.Contains(summery_VM.search)
                  || w.RptDate.ToString().Contains(summery_VM.search)
                  || w.Charged.ToString().Contains(summery_VM.search)
                  || w.Vat.ToString().Contains(summery_VM.search)
                  || w.NationalFees.ToString().Contains(summery_VM.search))
                  ).Select(s => new DDASCReport_VM
                  {
                      ACCT = s.Acct,
                      Branch_number = s.BranchNumber,
                      Charged = Convert.ToString(s.Charged),
                      Customer_Name = s.CustomerName,
                      RptDate = s.RptDate,
                      DDASCJ_ID = s.DdascjId,
                      National_Fees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                      VAT = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                  }).ToList();
                if (list.Count > 0)
                {
                    list.Add(new DDASCReport_VM
                    {
                        Customer_Name = "Totals: ",
                        Charged = String.Format("{0:0.00}", list.Select(s => Convert.ToDouble(s.Charged)).ToList().Sum()),
                        VAT = String.Format("{0:0.00}", list.Select(s => Convert.ToDouble(s.VAT)).ToList().Sum()),
                        National_Fees = String.Format("{0:0.00}", list.Select(s => Convert.ToDouble(s.National_Fees)).ToList().Sum()),
                    });
                    list = list.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                }
            }
            if (list.Count > 0)
            {
                ulong totalrecord = 0;
                if (string.IsNullOrEmpty(summery_VM.search) != true)
                {
                    totalrecord = (ulong)standing_Order_VATContext.Ddascjs.Where(w => w.BranchNumber == summery_VM.Branch.ToString()
                   && w.RptDate >= summery_VM.dateFrom && w.RptDate <= summery_VM.DateTo && w.Charged != 0.00
                   && (w.Acct.Contains(summery_VM.search) ||
                   w.CustomerName.Contains(summery_VM.search)
                   || w.RptDate.ToString().Contains(summery_VM.search)
                   || w.Charged.ToString().Contains(summery_VM.search)
                   || w.Vat.ToString().Contains(summery_VM.search)
                   || w.NationalFees.ToString().Contains(summery_VM.search))
                  ).Count();
                }
                else
                {
                    totalrecord = (ulong)standing_Order_VATContext.Ddascjs.Where(w => w.BranchNumber == summery_VM.Branch.ToString()
                    && w.RptDate >= summery_VM.dateFrom && w.RptDate <= summery_VM.DateTo && w.Charged != 0.00).Count();
                }
                list.FirstOrDefault().TotalRecordCount = totalrecord + 1;
            }

            return list;
        }
        public List<DDASCReport_VM_Download> GetDDASCReportDawnload(Summery_VM summery_VM)
        {
            List<DDASCReport_VM_Download> list = new List<DDASCReport_VM_Download>();
            if (string.IsNullOrEmpty(summery_VM.search) == true)
            {
                list = standing_Order_VATContext.Ddascjs.Where(w => w.BranchNumber == summery_VM.Branch.ToString()
                  && w.RptDate >= summery_VM.dateFrom && w.RptDate <= summery_VM.DateTo && w.Charged != 0.00).Select(s => new DDASCReport_VM_Download
                  {
                      ACCT = s.Acct,
                      Branch_number = s.BranchNumber,
                      Charged = Convert.ToString(s.Charged),
                      Customer_Name = s.CustomerName,
                      RptDate = s.RptDate.Value.ToString("MM/dd/yyyy"),
                      DDASCJ_ID = s.DdascjId,
                      National_Fees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                      VAT = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                  }).ToList();
            }
            else
            {
                list = standing_Order_VATContext.Ddascjs.Where(w => w.BranchNumber == summery_VM.Branch.ToString()
                  && w.RptDate >= summery_VM.dateFrom && w.RptDate <= summery_VM.DateTo && w.Charged != 0.00
                  && (w.Acct.Contains(summery_VM.search) ||
                  w.CustomerName.Contains(summery_VM.search)
                  || w.RptDate.ToString().Contains(summery_VM.search)
                  || w.Charged.ToString().Contains(summery_VM.search)
                  || w.Vat.ToString().Contains(summery_VM.search)
                  || w.NationalFees.ToString().Contains(summery_VM.search))).Select(s => new DDASCReport_VM_Download
                  {
                      ACCT = s.Acct,
                      Branch_number = s.BranchNumber,
                      Charged = Convert.ToString(s.Charged),
                      Customer_Name = s.CustomerName,
                      RptDate = s.RptDate.Value.ToString("MM/dd/yyyy"),
                      DDASCJ_ID = s.DdascjId,
                      National_Fees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                      VAT = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                  }).ToList();
            }
            if (list.Count > 0)
            {
                list.Add(new DDASCReport_VM_Download
                {
                    Customer_Name = "Totals: ",
                    //String.Format("{0:0.00}", list.Select(s => Convert.ToDouble(s.Charged)).ToList().Sum())
                    Charged = String.Format("{0:0.00}", list.Select(s => Convert.ToDouble(s.Charged)).ToList().Sum()),
                    VAT = String.Format("{0:0.00}", list.Select(s => Convert.ToDouble(s.VAT)).ToList().Sum()),
                    National_Fees = String.Format("{0:0.00}", list.Select(s => Convert.ToDouble(s.National_Fees)).ToList().Sum()),
                });
                //ulong totalrecord = (ulong)list.Count();
                //list.FirstOrDefault().TotalRecordCount = totalrecord;
            }

            return list;
        }
    }
}