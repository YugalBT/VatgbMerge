using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB;
using System.Runtime.InteropServices;

namespace Standing_Order_Vat_App.Common.Services
{

    public class TansChargeBranchService : ITansChargeBranch
    {
        private readonly Standing_Order_VATContext tansChageBranch;

        public TansChargeBranchService(Standing_Order_VATContext tansChageBranch)
        {
            this.tansChageBranch = tansChageBranch;
        }

        public List<TansChargeBranch_VM> GetCustomerTansChargeBranch(CustomerSummary_VM customerSummary_VM, [Optional] int pageNum, [Optional] int recordPerPage)
        {
            List<TansChargeBranch_VM> record = new List<TansChargeBranch_VM>();
            if (string.IsNullOrEmpty(customerSummary_VM.search) == true)
            {
                record = tansChageBranch.TansferCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate
                  && w.Dateactive <= customerSummary_VM.Enddate).Select(s => new TansChargeBranch_VM
                  {
                      Acct = s.Acct,
                      Branch = s.Branch,
                      CheckNumber = s.CheckNumber,
                      Cif = s.Cif,
                      Dateactive = s.Dateactive,
                      NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                      ProffSequence = s.ProffSequence,
                      TransAmt = String.Format("{0:0.00}", Convert.ToDouble(s.TransAmt)),
                      TransferChargeId = s.TransferChargeId,
                      Trasncode = s.Trasncode,
                      Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                  }).ToList();

                if (record.Count > 0)
                {
                    record.Add(new TansChargeBranch_VM
                    {
                        CheckNumber = "Totals:",
                        TransAmt = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.TransAmt))),
                        NationalFees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.NationalFees))),
                        Vat = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat)))
                    });
                    record = record.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                    ulong totalcout = (ulong)tansChageBranch.TansferCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate
                    && w.Dateactive <= customerSummary_VM.Enddate).Count();
                    record.FirstOrDefault().TotalRecordCount = totalcout+1;
                }
            }
            else
            {
                record = tansChageBranch.TansferCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate
                  && w.Dateactive <= customerSummary_VM.Enddate && (w.Acct.Contains(customerSummary_VM.search) || w.Dateactive.ToString().Contains(customerSummary_VM.search)
                 || w.Branch.Contains(customerSummary_VM.search) || w.ProffSequence.Contains(customerSummary_VM.search) || w.CheckNumber.Contains(customerSummary_VM.search)
                 || w.TransAmt.ToString().Contains(customerSummary_VM.search) || w.NationalFees.ToString().Contains(customerSummary_VM.search) || w.Vat.ToString().Contains(customerSummary_VM.search)
                 )).Select(s => new TansChargeBranch_VM
                 {
                     Acct = s.Acct,
                     Branch = s.Branch,
                     CheckNumber = s.CheckNumber,
                     Cif = s.Cif,
                     Dateactive = s.Dateactive,
                     NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                     ProffSequence = s.ProffSequence,
                     TransAmt = String.Format("{0:0.00}", Convert.ToDouble(s.TransAmt)),
                     TransferChargeId = s.TransferChargeId,
                     Trasncode = s.Trasncode,
                     Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),
                 }).ToList();

                if (record.Count > 0)
                {
                    record.Add(new TansChargeBranch_VM
                    {
                        CheckNumber = "Totals:",
                        TransAmt = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.TransAmt))),
                        NationalFees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.NationalFees))),
                        Vat = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat))),
                    });
                    record= record.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                    ulong totalcout = (ulong)tansChageBranch.TansferCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate
                    && w.Dateactive <= customerSummary_VM.Enddate && (w.Acct.Contains(customerSummary_VM.search) || w.Dateactive.ToString().Contains(customerSummary_VM.search)
                 || w.Branch.Contains(customerSummary_VM.search) || w.ProffSequence.Contains(customerSummary_VM.search) || w.CheckNumber.Contains(customerSummary_VM.search)
                 || w.TransAmt.ToString().Contains(customerSummary_VM.search) || w.NationalFees.ToString().Contains(customerSummary_VM.search) || w.Vat.ToString().Contains(customerSummary_VM.search)
                 )).Count();
                    record.FirstOrDefault().TotalRecordCount = totalcout+1;
                }
            }
            return record;
        }

        public List<TansChargeBranch_VM_Download> GetCustomerTansChargeBranchDawnload(CustomerSummary_VM customerSummary_VM)
        {
            List<TansChargeBranch_VM_Download> record = new List<TansChargeBranch_VM_Download>();
            if (string.IsNullOrEmpty(customerSummary_VM.search) == true)
            {
                record = tansChageBranch.TansferCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate
                  && w.Dateactive <= customerSummary_VM.Enddate).Select(s => new TansChargeBranch_VM_Download
                  {
                      Acct = s.Acct,
                      Branch = s.Branch,
                      CheckNumber = s.CheckNumber,
                      Cif = s.Cif,
                      Dateactive = s.Dateactive.Value.ToString("MM/dd/yyyy"),
                      NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                      ProffSequence = s.ProffSequence,
                      TransAmt = String.Format("{0:0.00}", Convert.ToDouble(s.TransAmt)),
                      TransferChargeId = s.TransferChargeId,
                      Trasncode = s.Trasncode,
                      Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),
                  }).ToList();
            }
            else
            {
                record = tansChageBranch.TansferCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate
                  && w.Dateactive <= customerSummary_VM.Enddate && (w.Acct.Contains(customerSummary_VM.search) || w.Dateactive.ToString().Contains(customerSummary_VM.search)
                 || w.Branch.Contains(customerSummary_VM.search) || w.ProffSequence.Contains(customerSummary_VM.search) || w.CheckNumber.Contains(customerSummary_VM.search)
                 || w.TransAmt.ToString().Contains(customerSummary_VM.search) || w.NationalFees.ToString().Contains(customerSummary_VM.search) || w.Vat.ToString().Contains(customerSummary_VM.search)
                 )).Select(s => new TansChargeBranch_VM_Download
                 {
                     Acct = s.Acct,
                     Branch = s.Branch,
                     CheckNumber = s.CheckNumber,
                     Cif = s.Cif,
                     Dateactive = s.Dateactive.Value.ToString("MM/dd/yyyy"),
                     NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                     ProffSequence = s.ProffSequence,
                     TransAmt = String.Format("{0:0.00}", Convert.ToDouble(s.TransAmt)),
                     TransferChargeId = s.TransferChargeId,
                     Trasncode = s.Trasncode,
                     Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                 }).ToList();
            }
            if (record.Count > 0)
            {
                record.Add(new TansChargeBranch_VM_Download
                {
                    CheckNumber = "Totals:",
                    TransAmt = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.TransAmt))),
                    NationalFees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.NationalFees))),
                    Vat = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat))),
                });
                //ulong totalcout = (ulong)tansChageBranch.TansferCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate
                //&& w.Dateactive <= customerSummary_VM.Enddate).Count();
                //record.FirstOrDefault().TotalRecordCount = totalcout;
            }
            return record;
        }

        public List<TansChargeBranch_VM> GetTansChargeBranch(Summery_VM summery_VM, [Optional] int pageNum, [Optional] int recordPerPage)
        {
            List<TansChargeBranch_VM> record = new List<TansChargeBranch_VM>();
            if (string.IsNullOrEmpty(summery_VM.search) == true)
            {
                record = tansChageBranch.TansferCharges.Where(w => w.Branch == summery_VM.Branch.ToString()
                 && w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo)
                    .Select(s => new TansChargeBranch_VM
                    {
                        Acct = s.Acct,
                        Branch = s.Branch,
                        CheckNumber = s.CheckNumber,
                        Cif = s.Cif,
                        Dateactive = s.Dateactive,
                        NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                        ProffSequence = s.ProffSequence,
                        TransAmt = String.Format("{0:0.00}", Convert.ToDouble(s.TransAmt)),
                        TransferChargeId = s.TransferChargeId,
                        Trasncode = s.Trasncode,
                        Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),
                    }).ToList();
                if (record.Count > 0)
                {
                    record.Add(new TansChargeBranch_VM
                    {
                        Branch = "Totals:",
                        TransAmt = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.TransAmt))),
                        NationalFees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat))),
                        Vat = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat)))
                    });
                    record = record.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                }
            }
            else
            {
                record = tansChageBranch.TansferCharges.Where(w => w.Branch == summery_VM.Branch.ToString()
                && w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo && (w.Cif.Contains(summery_VM.search) ||
                w.Acct.Contains(summery_VM.search) || w.Dateactive.ToString().Contains(summery_VM.search) || w.Branch.Contains(summery_VM.search)
                || w.TransAmt.ToString().Contains(summery_VM.search) || w.NationalFees.ToString().Contains(summery_VM.search) || w.Vat.ToString().Contains(summery_VM.search)))
                   .Select(s => new TansChargeBranch_VM
                   {
                       Acct = s.Acct,
                       Branch = s.Branch,
                       CheckNumber = s.CheckNumber,
                       Cif = s.Cif,
                       Dateactive = s.Dateactive,
                       NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                       ProffSequence = s.ProffSequence,
                       TransAmt = String.Format("{0:0.00}", Convert.ToDouble(s.TransAmt)),
                       TransferChargeId = s.TransferChargeId,
                       Trasncode = s.Trasncode,
                       Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),
                   }).ToList();
                if (record.Count > 0)
                {
                    record.Add(new TansChargeBranch_VM
                    {
                        Branch = "Totals:",
                        // String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Totalfees)))
                        TransAmt= String.Format("{0:0.00}",record.Sum(s =>Convert.ToDouble (s.TransAmt))),
                        //TransAmt = record.Sum(s => s.TransAmt),
                        NationalFees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.NationalFees))),
                        Vat = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat))),
                    });
                    record = record.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                }
            }
            if (record.Count() > 0)
            {
                ulong totalrecord = 0;
                if (string.IsNullOrEmpty(summery_VM.search) == true)
                {
                    totalrecord = (ulong)tansChageBranch.TansferCharges.Where(w => w.Branch == summery_VM.Branch.ToString()
               && w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo).Count();
                }
                else
                {
                    totalrecord = (ulong)tansChageBranch.TansferCharges.Where(w => w.Branch == summery_VM.Branch.ToString()
                && w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo && (w.Cif.Contains(summery_VM.search) ||
                w.Acct.Contains(summery_VM.search) || w.Dateactive.ToString().Contains(summery_VM.search) || w.Branch.Contains(summery_VM.search)
                || w.TransAmt.ToString().Contains(summery_VM.search) || w.NationalFees.ToString().Contains(summery_VM.search) || w.Vat.ToString().Contains(summery_VM.search))).Count();
                }
                record.FirstOrDefault().TotalRecordCount = totalrecord+1;
            }

            return record;
        }

        public List<TansChargeBranch_VM_Download> GetTansChargeBranchDawnload(Summery_VM summery_VM)
        {
            List<TansChargeBranch_VM_Download> record = new List<TansChargeBranch_VM_Download>();
            if (string.IsNullOrEmpty(summery_VM.search) == true)
            {
                record = tansChageBranch.TansferCharges.Where(w => w.Branch == summery_VM.Branch.ToString()
                 && w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo)
                    .Select(s => new TansChargeBranch_VM_Download
                    {
                        Acct = s.Acct,
                        Branch = s.Branch,
                        CheckNumber = s.CheckNumber,
                        Cif = s.Cif,
                        Dateactive = s.Dateactive.Value.ToString("MM/dd/yyyy"),
                        NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                        ProffSequence = s.ProffSequence,
                        TransAmt = String.Format("{0:0.00}", Convert.ToDouble(s.TransAmt)),
                        TransferChargeId = s.TransferChargeId,
                        Trasncode = s.Trasncode,
                        Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                    }).ToList();
            }
            else
            {
                record = tansChageBranch.TansferCharges.Where(w => w.Branch == summery_VM.Branch.ToString()
                 && w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo && (w.Cif.Contains(summery_VM.search) ||
                w.Acct.Contains(summery_VM.search) || w.Dateactive.ToString().Contains(summery_VM.search) || w.Branch.Contains(summery_VM.search)
                || w.TransAmt.ToString().Contains(summery_VM.search) || w.NationalFees.ToString().Contains(summery_VM.search) || w.Vat.ToString().Contains(summery_VM.search)))
                    .Select(s => new TansChargeBranch_VM_Download
                    {
                        Acct = s.Acct,
                        Branch = s.Branch,
                        CheckNumber = s.CheckNumber,
                        Cif = s.Cif,
                        Dateactive = s.Dateactive.Value.ToString("MM/dd/yyyy"),
                        NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                        ProffSequence = s.ProffSequence,
                        TransAmt = String.Format("{0:0.00}", Convert.ToDouble(s.TransAmt)),
                        TransferChargeId = s.TransferChargeId,
                        Trasncode = s.Trasncode,
                        Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                    }).ToList();
            }
            if (record.Count() > 0)
            {
                record.Add(new TansChargeBranch_VM_Download
                {
                    Branch = "Totals:",
                    // String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Totalfees)))
                    TransAmt = String.Format("{0:0.00}", record.Sum(s =>Convert.ToDouble(s.TransAmt))),
                    NationalFees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.NationalFees))),
                    Vat = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat))),
                });
                //ulong totalrecord = (ulong)record.Count();
                //record.FirstOrDefault().TotalRecordCount = totalrecord;
            }
            return record;
        }
    }
}
