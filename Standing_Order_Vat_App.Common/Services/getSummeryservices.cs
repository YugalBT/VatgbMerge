using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB;
using System.Linq;
using System.Runtime.InteropServices;

namespace Standing_Order_Vat_App.Common.Services
{
    public class getSummeryservices : IgetSummary
    {
        private readonly Standing_Order_VATContext standing_Order_VATContext;

        public getSummeryservices(Standing_Order_VATContext standing_Order_VATContext)
        {
            this.standing_Order_VATContext = standing_Order_VATContext;
        }

        public List<StandingOrder_VM> GetCustomerDetail(CustomerSummary_VM customerSummary_VM, [Optional] int pageNum, [Optional] int recordPerPage)
        {
            List<StandingOrder_VM> lst = new List<StandingOrder_VM>();
            if (string.IsNullOrEmpty(customerSummary_VM.search) == true)
            {
                lst = standing_Order_VATContext.StandingOrders.Where(w => w.Acct == customerSummary_VM.acct.ToString()
                && w.DateActive >= customerSummary_VM.Startdate && w.DateActive <= customerSummary_VM.Enddate && w.OffsetAcctNumber.StartsWith("66070"))
                    .Select(s => new StandingOrder_VM
                    {
                        Acct = s.Acct,
                        BranchNumber = s.BranchNumber,
                        DateActive = s.DateActive,
                        NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                        OffsetAcctNumber = s.OffsetAcctNumber,

                        TotalFees = Convert.ToString(s.TotalFees),
                        Vat = String.Format("{0:0.00}",Convert.ToDouble (s.Vat)),
                    }).AsEnumerable().ToList();
                if (lst.Count > 0)
                {
                    lst.Add(new StandingOrder_VM
                    {
                        OffsetAcctNumber = "Totals:",
                        TotalFees = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.TotalFees)).ToList().Sum()),
                        NationalFees = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.NationalFees)).ToList().Sum()),
                        Vat = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.Vat)).ToList().Sum()),
                        // Vat=lst.Select(s => s.Vat).ToList().Sum()
                    });
                    lst = lst.Skip(pageNum * recordPerPage).Take(recordPerPage).AsEnumerable().ToList();
                }
            }
            else
            {
                lst = standing_Order_VATContext.StandingOrders.Where(w => w.Acct == customerSummary_VM.acct.ToString()
                && w.DateActive >= customerSummary_VM.Startdate && w.DateActive <= customerSummary_VM.Enddate && (w.Acct.Contains(customerSummary_VM.search) || w.BranchNumber.Contains(customerSummary_VM.search)
                || w.DateActive.ToString().Contains(customerSummary_VM.search) || w.NationalFees.ToString().Contains(customerSummary_VM.search) || w.OffsetAcctNumber.Contains(customerSummary_VM.search) ||
                w.TotalFees.ToString().Contains(customerSummary_VM.search) || w.Vat.ToString().Contains(customerSummary_VM.search)))
                    .Select(s => new StandingOrder_VM
                    {
                        Acct = s.Acct,
                        BranchNumber = s.BranchNumber,
                        DateActive = s.DateActive,
                        NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                        OffsetAcctNumber = s.OffsetAcctNumber,
                        TotalFees =Convert.ToString(s.TotalFees),
                        Vat =Convert.ToString (s.Vat)
                    }).AsEnumerable().ToList();
                if (lst.Count > 0)
                {
                    lst.Add(new StandingOrder_VM
                    {
                        OffsetAcctNumber = "Totals:",
                       // String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Totalfees)))
                        TotalFees= String.Format("{0:0.00}", lst.Select(s =>Convert.ToDouble(s.TotalFees)).ToList().Sum()),
                        //TotalFees = lst.Select(s => s.TotalFees).ToList().Sum(),
                        NationalFees = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.NationalFees)).ToList().Sum()),
                        Vat = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.Vat)).ToList().Sum()),
                    });
                    lst = lst.Skip(pageNum * recordPerPage).Take(recordPerPage).AsEnumerable().ToList();
                }
            }
            if (lst.Count > 0)
            {
                ulong totalrecord = 0;
                if (string.IsNullOrEmpty(customerSummary_VM.search) == true)
                {
                    totalrecord = (ulong)standing_Order_VATContext.StandingOrders.Where(w => w.Acct == customerSummary_VM.acct.ToString()
                    && w.DateActive >= customerSummary_VM.Startdate && w.DateActive <= customerSummary_VM.Enddate && w.OffsetAcctNumber.StartsWith("66070")).Count();
                }
                else
                {
                    totalrecord = (ulong)standing_Order_VATContext.StandingOrders.Where(w => w.Acct == customerSummary_VM.acct.ToString()
                      && w.DateActive >= customerSummary_VM.Startdate && w.DateActive <= customerSummary_VM.Enddate && w.OffsetAcctNumber.StartsWith("66070") &&
                (w.BranchNumber.Contains(customerSummary_VM.search)
                || w.DateActive.ToString().Contains(customerSummary_VM.search) || w.Acct.Contains(customerSummary_VM.search) || w.OffsetAcctNumber.Contains(customerSummary_VM.search)
                || w.TotalFees.ToString().Contains(customerSummary_VM.search) || w.NationalFees.ToString().Contains(customerSummary_VM.search)
                || w.Vat.ToString().Contains(customerSummary_VM.search))).Count();
                }
                lst.FirstOrDefault().TotalRecordCount = totalrecord+1;
            }
            return lst;
        }


        public List<StandingOrder_VM_Download> GetCustomerDetailDawnload(CustomerSummary_VM customerSummary_VM)
        {
            List<StandingOrder_VM_Download> lst = new List<StandingOrder_VM_Download>();
            if (string.IsNullOrEmpty(customerSummary_VM.search) == true)
            {
                lst = standing_Order_VATContext.StandingOrders.Where(w => w.Acct == customerSummary_VM.acct.ToString()
               && w.DateActive >= customerSummary_VM.Startdate && w.DateActive <= customerSummary_VM.Enddate && w.OffsetAcctNumber.StartsWith("66070"))
                   .Select(s => new StandingOrder_VM_Download
                   {
                       Acct = s.Acct,
                       BranchNumber = s.BranchNumber,
                       DateActive = s.DateActive.Value.ToString("MM/dd/yyyy"),
                       NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                       OffsetAcctNumber = s.OffsetAcctNumber,
                       TotalFees =Convert.ToString(s.TotalFees),
                       Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                   }).ToList();
            }
            else
            {
                lst = standing_Order_VATContext.StandingOrders.Where(w => w.Acct == customerSummary_VM.acct.ToString()
               && w.DateActive >= customerSummary_VM.Startdate && w.DateActive <= customerSummary_VM.Enddate && w.OffsetAcctNumber.StartsWith("66070") && (w.Acct.Contains(customerSummary_VM.search) || w.BranchNumber.Contains(customerSummary_VM.search)
                || w.DateActive.ToString().Contains(customerSummary_VM.search) || w.NationalFees.ToString().Contains(customerSummary_VM.search) || w.OffsetAcctNumber.Contains(customerSummary_VM.search) ||
                w.TotalFees.ToString().Contains(customerSummary_VM.search) || w.Vat.ToString().Contains(customerSummary_VM.search)))
                   .Select(s => new StandingOrder_VM_Download
                   {
                       Acct = s.Acct,
                       BranchNumber = s.BranchNumber,
                       DateActive = s.DateActive.Value.ToString("MM/dd/yyyy"),
                       NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                       OffsetAcctNumber = s.OffsetAcctNumber,
                       TotalFees =Convert.ToString(s.TotalFees),
                       Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                   }).ToList();
            }


            if (lst.Count > 0)
            {
                lst.Add(new StandingOrder_VM_Download
                {
                    OffsetAcctNumber = "Totals:",
                    TotalFees = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.TotalFees)).ToList().Sum()),
                    NationalFees = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.NationalFees)).ToList().Sum()),
                    Vat = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.Vat)).ToList().Sum())
                });
                //ulong totalrecord = (ulong)lst.Count();
                //lst.FirstOrDefault().TotalRecordCount = totalrecord;

            }
            return lst;
        }

        public List<StandingOrder_VM> GetSummaryReport(Summery_VM summery_VM, [Optional] int pageNum, [Optional] int recordPerPage)
        {
            List<StandingOrder_VM> lst = new List<StandingOrder_VM>();
            if (string.IsNullOrEmpty(summery_VM.search) == true)
            {

                lst = standing_Order_VATContext.StandingOrders.Where(w => w.BranchNumber == summery_VM.Branch.ToString()
                 && w.DateActive >= summery_VM.dateFrom && w.DateActive <= summery_VM.DateTo && w.OffsetAcctNumber.StartsWith("66070")
                 && w.Acct != "TOTALS").Select(s => new StandingOrder_VM
                 {
                     Acct = s.Acct,
                     BranchNumber = s.BranchNumber,
                     DateActive = s.DateActive,
                     NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                     OffsetAcctNumber = s.OffsetAcctNumber,
                     TotalFees =Convert.ToString(s.TotalFees),
                     Vat = String.Format("{0:0.00}",Convert.ToDouble(s.Vat)),
                     //Convert.ToString(s.Vat),
                 }).ToList();
                if (lst.Count > 0)
                {
                    lst.Add(new StandingOrder_VM
                    {
                        OffsetAcctNumber = "Totals:",
                        TotalFees = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.TotalFees)).ToList().Sum()),
                        NationalFees = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.NationalFees)).ToList().Sum()),
                        Vat = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.Vat)).ToList().Sum()),
                    });
                    lst = lst.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                }
            }
            else
            {
                lst = standing_Order_VATContext.StandingOrders.Where(w => w.BranchNumber == summery_VM.Branch.ToString()
                && w.DateActive >= summery_VM.dateFrom && w.DateActive <= summery_VM.DateTo && w.OffsetAcctNumber.StartsWith("66070")
                && w.Acct != "TOTALS"
                && (w.BranchNumber.Contains(summery_VM.search) || w.DateActive.ToString().Contains(summery_VM.search)
                || w.Acct.Contains(summery_VM.search) || w.OffsetAcctNumber.Contains(summery_VM.search) || w.TotalFees.ToString().Contains(summery_VM.search)
                || w.NationalFees.ToString().Contains(summery_VM.search) || w.Vat.ToString().Contains(summery_VM.search))).Select(s => new StandingOrder_VM
                {
                    Acct = s.Acct,
                    BranchNumber = s.BranchNumber,
                    DateActive = s.DateActive,
                    NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                    OffsetAcctNumber = s.OffsetAcctNumber,
                    TotalFees =Convert.ToString(s.TotalFees),
                    Vat =String.Format("{0:0.00}",Convert.ToDouble(s.Vat)),
                }).ToList();
                if (lst.Count > 0)
                {
                    lst.Add(new StandingOrder_VM
                    {
                        OffsetAcctNumber = "Totals:",
                        TotalFees = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.TotalFees)).ToList().Sum()),
                        NationalFees = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.NationalFees)).ToList().Sum()),
                        Vat = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.Vat)).ToList().Sum()),
                    });
                    lst = lst.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                }
            }
            if (lst.Count > 0)
            {
                ulong totalcount = 0;
                if (string.IsNullOrEmpty(summery_VM.search) == true)
                {
                    totalcount = (ulong)standing_Order_VATContext.StandingOrders.Where(w => w.BranchNumber == summery_VM.Branch.ToString()
                 && w.DateActive >= summery_VM.dateFrom && w.DateActive <= summery_VM.DateTo && w.OffsetAcctNumber.StartsWith("66070")
                 && w.Acct != "TOTALS").Count();
                }
                else
                {
                    totalcount = (ulong)standing_Order_VATContext.StandingOrders.Where(w => w.BranchNumber == summery_VM.Branch.ToString()
                 && w.DateActive >= summery_VM.dateFrom && w.DateActive <= summery_VM.DateTo && w.OffsetAcctNumber.StartsWith("66070")
                 && w.Acct != "TOTALS" && (w.BranchNumber.Contains(summery_VM.search) || w.DateActive.ToString().Contains(summery_VM.search)
               || w.Acct.Contains(summery_VM.search) || w.OffsetAcctNumber.Contains(summery_VM.search) || w.TotalFees.ToString().Contains(summery_VM.search)
               || w.NationalFees.ToString().Contains(summery_VM.search) || w.Vat.ToString().Contains(summery_VM.search))).Count();
                }
                lst.FirstOrDefault().TotalRecordCount = totalcount+1;
            }

            return lst;
        }


        public List<StandingOrder_VM_Download> GetSummaryReportDawnload(Summery_VM summery_VM)
        {
            List<StandingOrder_VM_Download> lst = new List<StandingOrder_VM_Download>();
            if (string.IsNullOrEmpty(summery_VM.search))
            {
                lst = standing_Order_VATContext.StandingOrders.Where(w => w.BranchNumber == summery_VM.Branch.ToString()
                 && w.DateActive >= summery_VM.dateFrom && w.DateActive <= summery_VM.DateTo && w.OffsetAcctNumber.StartsWith("66070")
                 && w.Acct != "TOTALS").Select(s => new StandingOrder_VM_Download
                 {
                     Acct = s.Acct,
                     BranchNumber = s.BranchNumber,
                     DateActive = s.DateActive.Value.ToString("MM/dd/yyyy"),
                     NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                     OffsetAcctNumber = s.OffsetAcctNumber,
                     TotalFees =Convert.ToString(s.TotalFees),
                     Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),

                 }).ToList();
            }
            else
            {
                lst = standing_Order_VATContext.StandingOrders.Where(w => w.BranchNumber == summery_VM.Branch.ToString()
                 && w.DateActive >= summery_VM.dateFrom && w.DateActive <= summery_VM.DateTo && w.OffsetAcctNumber.StartsWith("66070")
                 && w.Acct != "TOTALS" && (w.BranchNumber.Contains(summery_VM.search) || w.DateActive.ToString().Contains(summery_VM.search)
                || w.Acct.Contains(summery_VM.search) || w.OffsetAcctNumber.Contains(summery_VM.search) || w.TotalFees.ToString().Contains(summery_VM.search)
                || w.NationalFees.ToString().Contains(summery_VM.search) || w.Vat.ToString().Contains(summery_VM.search))).Select(s => new StandingOrder_VM_Download
                {
                    Acct = s.Acct,
                    BranchNumber = s.BranchNumber,
                    DateActive =  s.DateActive.Value.ToString("MM/dd/yyyy"),
                    NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                    OffsetAcctNumber = s.OffsetAcctNumber,
                    TotalFees =Convert.ToString(s.TotalFees),
                    Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),

                }).ToList();
            }
            if (lst.Count > 0)
            {
                lst.Add(new StandingOrder_VM_Download
                {
                    OffsetAcctNumber = "Totals:",
                    //String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.TotalFees)).ToList().Sum())
                    TotalFees = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.TotalFees)).ToList().Sum()),
                    NationalFees = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.NationalFees)).ToList().Sum()),
                    Vat = String.Format("{0:0.00}", lst.Select(s => Convert.ToDouble(s.Vat)).ToList().Sum()),
                });
                ulong totalcount = (ulong)lst.Count();
                //lst.FirstOrDefault().TotalRecordCount = totalcount;
            }

            return lst;
        }
    }
}
