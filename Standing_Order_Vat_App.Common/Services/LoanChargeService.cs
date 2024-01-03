using Newtonsoft.Json.Linq;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

namespace Standing_Order_Vat_App.Common.Services
{
    public class LoanChargeService : IGetLoanCharge
    {
        private readonly Standing_Order_VATContext LoanCharge;

        public LoanChargeService(Standing_Order_VATContext LoanCharge)
        {
            this.LoanCharge = LoanCharge;
        }

        public List<LoanCharge_VM> GetCustomerLoanCharge(CustomerSummary_VM customerSummary_VM, [Optional] int pageNum, [Optional] int recordPerPage)
        {
            List<LoanCharge_VM> record = new List<LoanCharge_VM>();
            if (string.IsNullOrEmpty(customerSummary_VM.search) == true)
            {
                record = LoanCharge.LoanCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate &&
                 w.Dateactive <= customerSummary_VM.Enddate).Select(s => new LoanCharge_VM
                 {
                     Acct = s.Acct,
                     Branch = s.Branch,
                     Dateactive = s.Dateactive,
                     LoanChargeId = s.LoanChargeId,
                     Name = s.Name,
                     Nationalfees = String.Format("{0:0.00}", Convert.ToDouble(s.Nationalfees)),
                     Totalfees = String.Format("{0:0.00}", Convert.ToDouble(s.Totalfees)),
                     Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),
                 }).ToList();
                if (record.Count > 0)
                {
                    record.Add(new LoanCharge_VM
                    {

                       // Acct = "Totals:",
                        Acct= "Totals:",
                      //Math.Round(inputValue, 2, MidpointRounding.AwayFromZero)
                      //Totalfees= (Math.Round((double)record.Sum(s => s.Totalfees),2,MidpointRounding.AwayFromZero)),
                      Totalfees= String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Totalfees))),
                   

                    Nationalfees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Nationalfees))),
                        Vat = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat)))
                    });
                    record = record.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                    ulong totalcout = (ulong)LoanCharge.LoanCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate &&
                    w.Dateactive <= customerSummary_VM.Enddate).Count();
                    record.FirstOrDefault().TotalRecordCount = totalcout + 1;

                }
            }
            else
            {
                record = LoanCharge.LoanCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate &&
                 w.Dateactive <= customerSummary_VM.Enddate && (w.Branch.Contains(customerSummary_VM.search) || w.Acct.Contains(customerSummary_VM.search) ||
                 w.Dateactive.ToString().Contains(customerSummary_VM.search) || w.Totalfees.ToString().Contains(customerSummary_VM.search) || w.Nationalfees.ToString().Contains(customerSummary_VM.search)
                 || w.Vat.ToString().Contains(customerSummary_VM.search)))
                    .Select(s => new LoanCharge_VM
                    {
                        Acct = s.Acct,
                        Branch = s.Branch,
                        Dateactive = s.Dateactive,
                        LoanChargeId = s.LoanChargeId,
                        Name = s.Name,
                        Nationalfees = String.Format("{0:0.00}", Convert.ToDouble(s.Nationalfees)),
                        Totalfees = String.Format("{0:0.00}", Convert.ToDouble(s.Totalfees)),
                        Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),
                    }).ToList();
                if (record.Count > 0)
                {
                    record.Add(new LoanCharge_VM
                    {
                        Acct = "Totals:",
                        Totalfees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Totalfees))),
                        Nationalfees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Nationalfees))),
                        Vat = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat)))
                    });
                    record = record.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                    ulong totalcout = (ulong)LoanCharge.LoanCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate &&
                 w.Dateactive <= customerSummary_VM.Enddate && (w.Branch.Contains(customerSummary_VM.search) || w.Acct.Contains(customerSummary_VM.search) ||
                 w.Dateactive.ToString().Contains(customerSummary_VM.search) || w.Totalfees.ToString().Contains(customerSummary_VM.search) || w.Nationalfees.ToString().Contains(customerSummary_VM.search)
                 || w.Vat.ToString().Contains(customerSummary_VM.search))).Count();
                    record.FirstOrDefault().TotalRecordCount = totalcout + 1;

                }
            }
            return record;
        }

        public List<LoanCharge_VM_Download> GetCustomerLoanChargeDawnload(CustomerSummary_VM customerSummary_VM)
        {
            List<LoanCharge_VM_Download> record = new List<LoanCharge_VM_Download>();
            if (string.IsNullOrEmpty(customerSummary_VM.search) == true)
            {
                record = LoanCharge.LoanCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate &&
                 w.Dateactive <= customerSummary_VM.Enddate).Select(s => new LoanCharge_VM_Download
                 {
                     Acct = s.Acct,
                     Branch = s.Branch,
                     Dateactive = s.Dateactive.Value.ToString("MM/dd/yyyy"),
                     LoanChargeId = s.LoanChargeId,
                     Name = s.Name,
                     Nationalfees = String.Format("{0:0.00}", Convert.ToDouble(s.Nationalfees)),
                     Totalfees = String.Format("{0:0.00}", Convert.ToDouble(s.Totalfees)),
                     Vat = s.Vat
                 }).ToList();
            }
            else
            {
                record = LoanCharge.LoanCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate &&
                 w.Dateactive <= customerSummary_VM.Enddate && (w.Branch.Contains(customerSummary_VM.search) || w.Acct.Contains(customerSummary_VM.search) ||
                 w.Dateactive.ToString().Contains(customerSummary_VM.search) || w.Totalfees.ToString().Contains(customerSummary_VM.search) || w.Nationalfees.ToString().Contains(customerSummary_VM.search)
                 || w.Vat.ToString().Contains(customerSummary_VM.search))).Select(s => new LoanCharge_VM_Download
                 {
                     Acct = s.Acct,
                     Branch = s.Branch,
                     Dateactive = s.Dateactive.Value.ToString("MM/dd/yyyy"),
                     LoanChargeId = s.LoanChargeId,
                     Name = s.Name,
                     Nationalfees =String.Format("{0:0.00}", Convert.ToDouble(s.Nationalfees)),
                     Totalfees = Convert.ToString(s.Totalfees),
                     Vat = s.Vat
                 }).ToList();
            }
            if (record.Count > 0)
            {

                record.Add(new LoanCharge_VM_Download
                {
                    Acct = "Totals:",
                    Totalfees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Totalfees))),
                    Nationalfees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Nationalfees))),
                    Vat = record.Sum(s => s.Vat)
                });
                //ulong totalcout = (ulong)record.Count();
                //record.FirstOrDefault().TotalRecordCount = totalcout;

            }
            return record;
        }

        public List<LoanCharge_VM> GetLoanCharge(Summery_VM summery_VM, [Optional] int pageNum, [Optional] int recordPerPage)
        {
            List<LoanCharge_VM> record = new List<LoanCharge_VM>();
            if (string.IsNullOrEmpty(summery_VM.search) == true)
            {
                record = LoanCharge.LoanCharges.Where(w => w.Branch == summery_VM.Branch.ToString() && w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo)
                    .Select(s => new LoanCharge_VM
                    {
                        Acct = s.Acct,
                        Branch = s.Branch,
                        Dateactive = s.Dateactive,
                        LoanChargeId = s.LoanChargeId,
                        Name = s.Name,
                        Nationalfees = String.Format("{0:0.00}",Convert.ToDouble(s.Nationalfees)),
                        Totalfees = String.Format("{0:0.00}", Convert.ToDouble(s.Totalfees)),
                        Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),
                    }).ToList();
                if (record.Count > 0)
                {
                    record.Add(new LoanCharge_VM
                    {
                        Acct = "Totals:",
                        Totalfees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Totalfees))),
                        Nationalfees = String.Format("{0:0.00}",record.Sum(s=>Convert.ToDouble(s.Nationalfees))),
                        Vat = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat)))
                    });
                    record = record.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                }
            }
            else
            {
                record = LoanCharge.LoanCharges.Where(w => w.Branch == summery_VM.Branch.ToString()
                && w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo
                && (w.Branch.Contains(summery_VM.search) || w.Acct.Contains(summery_VM.search)
                || w.Dateactive.ToString().Contains(summery_VM.search)
                || w.Totalfees.ToString().Contains(summery_VM.search) || w.Nationalfees.ToString().Contains(summery_VM.search)
                || w.Vat.ToString().Contains(summery_VM.search)))
                   .Select(s => new LoanCharge_VM
                   {
                       Acct = s.Acct,
                       Branch = s.Branch,
                       Dateactive = s.Dateactive,
                       LoanChargeId = s.LoanChargeId,
                       Name = s.Name,
                       Nationalfees = String.Format("{0:0.00}", Convert.ToDouble(s.Nationalfees)),
                       Totalfees = String.Format("{0:0.00}", Convert.ToDouble(s.Totalfees)),
                       Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),
                   }).ToList();
                if (record.Count > 0)
                {
                    record.Add(new LoanCharge_VM
                    {
                        Acct = "Totals:",
                        Totalfees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Totalfees))),
                        Nationalfees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Nationalfees))),
                        Vat = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat)))
                    });
                    record = record.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                }
            }
            if (record.Count > 0)
            {
                ulong totalrecord = 0;
                if (string.IsNullOrEmpty(summery_VM.search) == true)
                {
                    totalrecord = (ulong)LoanCharge.LoanCharges.Where(w => w.Branch == summery_VM.Branch.ToString() &&
                    w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo).Count();
                }
                else
                {
                    totalrecord = (ulong)LoanCharge.LoanCharges.Where(w => w.Branch == summery_VM.Branch.ToString() &&
                    w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo &&
                    (w.Branch.Contains(summery_VM.search) || w.Acct.Contains(summery_VM.search)
                || w.Dateactive.ToString().Contains(summery_VM.search)
                || w.Totalfees.ToString().Contains(summery_VM.search) || w.Nationalfees.ToString().Contains(summery_VM.search)
                || w.Vat.ToString().Contains(summery_VM.search))).Count();
                }
                record.FirstOrDefault().TotalRecordCount = totalrecord+1;
            }
            return record;
        }
        public List<LoanCharge_VM_Download> GetLoanChargeDawnload(Summery_VM summery_VM)
        {
            List<LoanCharge_VM_Download> record = new List<LoanCharge_VM_Download>();
            if (string.IsNullOrEmpty(summery_VM.search) == true)
            {

                record = LoanCharge.LoanCharges.Where(w => w.Branch == summery_VM.Branch.ToString() && w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo)
                    .Select(s => new LoanCharge_VM_Download
                    {
                        Acct = s.Acct,
                        Branch = s.Branch,
                        Dateactive = s.Dateactive.Value.ToString("MM/dd/yyyy"),
                        LoanChargeId = s.LoanChargeId,
                        Name = s.Name,
                        Nationalfees = String.Format("{0:0.00}", Convert.ToDouble(s.Nationalfees)),
                        Totalfees = String.Format("{0:0.00}", Convert.ToDouble(s.Totalfees)),
                        Vat = s.Vat
                    }).ToList();
            }
            else
            {
                record = LoanCharge.LoanCharges.Where(w => w.Branch == summery_VM.Branch.ToString() && w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo
                && (w.Branch.Contains(summery_VM.search) || w.Acct.Contains(summery_VM.search)
                || w.Dateactive.ToString().Contains(summery_VM.search)
                || w.Totalfees.ToString().Contains(summery_VM.search) || w.Nationalfees.ToString().Contains(summery_VM.search)
                || w.Vat.ToString().Contains(summery_VM.search)))
                .Select(s => new LoanCharge_VM_Download
                {
                    Acct = s.Acct,
                    Branch = s.Branch,
                    Dateactive = s.Dateactive.Value.ToString("MM/dd/yyyy"),
                    LoanChargeId = s.LoanChargeId,
                    Name = s.Name,
                    Nationalfees = String.Format("{0:0.00}", Convert.ToDouble(s.Nationalfees)),
                    Totalfees = String.Format("{0:0.00}", Convert.ToDouble(s.Totalfees)),
                    Vat = s.Vat
                }).ToList();
            }
            if (record.Count > 0)
            {
                record.Add(new LoanCharge_VM_Download
                {
                    Acct = "Totals:",
                    //String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Totalfees)))
                    Totalfees = String.Format("{0:0.00}", record.Sum(s =>Convert.ToDouble(s.Totalfees))),
                    Nationalfees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Nationalfees))),
                    Vat = record.Sum(s => s.Vat)
                });
                //ulong totalrecord = (ulong)record.Count();
                //record.FirstOrDefault().TotalRecordCount = totalrecord;
            }

            return record;
        }
    }
}
