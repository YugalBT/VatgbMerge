using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB;
using System.Runtime.InteropServices;

namespace Standing_Order_Vat_App.Common.Services
{
    public class getStopPayBranchService : IStopPayCharge
    {
        private readonly Standing_Order_VATContext stopPayCharge;

        public getStopPayBranchService(Standing_Order_VATContext stopPayCharge)
        {
            this.stopPayCharge = stopPayCharge;
        }

        public List<StopPayCharge_VM> GetCustomerStopPayCharge(CustomerSummary_VM customerSummary_VM, [Optional] int pageNum, [Optional] int recordPerPage)
        {
            List<StopPayCharge_VM> record = new List<StopPayCharge_VM>();
            if (string.IsNullOrEmpty(customerSummary_VM.search))
            {
                record = stopPayCharge.StopCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate
                && w.Dateactive <= customerSummary_VM.Enddate).Select(s => new StopPayCharge_VM
                {
                    Acct = s.Acct,
                    Branch = s.Branch,
                    CheckNumber = s.CheckNumber,
                    Cif = s.Cif,
                    Dateactive = s.Dateactive,
                    NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                    ProofSequence = s.ProofSequence,
                    StopchargeId = s.StopchargeId,
                    TransAmt =Convert.ToString(s.TransAmt),
                    Transcode = s.Transcode,
                    Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),

                }).ToList();
                if (record.Count > 0)
                {
                    record.Add(new StopPayCharge_VM
                    {
                        CheckNumber = "Total:",
                        // String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Totalfees)))
                        TransAmt = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.TransAmt))),
                        //TransAmt = record.Sum(s => s.TransAmt),
                        NationalFees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.NationalFees))),
                        Vat = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat)))
                    });
                    record = record.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                    ulong totalrecord = (ulong)stopPayCharge.StopCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate
                  && w.Dateactive <= customerSummary_VM.Enddate).Count();
                    record.FirstOrDefault().TotalRecordCount = totalrecord + 1;
                }
            }
            else
            {
                record = stopPayCharge.StopCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate
                && w.Dateactive <= customerSummary_VM.Enddate && (w.Cif.Contains(customerSummary_VM.search) || w.Acct.Contains(customerSummary_VM.search) ||
                w.Dateactive.ToString().Contains(customerSummary_VM.search) || w.Branch.Contains(customerSummary_VM.search) || w.ProofSequence.Contains(customerSummary_VM.search) ||
                w.CheckNumber.Contains(customerSummary_VM.search) || w.TransAmt.ToString().Contains(customerSummary_VM.search) || w.NationalFees.ToString().Contains(customerSummary_VM.search)
                || w.Vat.ToString().Contains(customerSummary_VM.search))).Select(s => new StopPayCharge_VM
                {
                    Acct = s.Acct,
                    Branch = s.Branch,
                    CheckNumber = s.CheckNumber,
                    Cif = s.Cif,
                    Dateactive = s.Dateactive,
                    NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                    ProofSequence = s.ProofSequence,
                    StopchargeId = s.StopchargeId,
                    TransAmt =Convert.ToString(s.TransAmt),
                    Transcode = s.Transcode,
                    Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))

                }).ToList();
                if (record.Count > 0)
                {
                    record.Add(new StopPayCharge_VM
                    {
                        CheckNumber = "Total:",
                        TransAmt = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.TransAmt))),
                        NationalFees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.NationalFees))),
                        Vat = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat))),
                    });
                    record = record.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();

                    ulong totalrecord = (ulong)stopPayCharge.StopCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate
                  && w.Dateactive <= customerSummary_VM.Enddate && (w.Cif.Contains(customerSummary_VM.search) || w.Acct.Contains(customerSummary_VM.search) ||
                w.Dateactive.ToString().Contains(customerSummary_VM.search) || w.Branch.Contains(customerSummary_VM.search) || w.ProofSequence.Contains(customerSummary_VM.search) ||
                w.CheckNumber.Contains(customerSummary_VM.search) || w.TransAmt.ToString().Contains(customerSummary_VM.search) || w.NationalFees.ToString().Contains(customerSummary_VM.search)
                || w.Vat.ToString().Contains(customerSummary_VM.search))).Count();
                    record.FirstOrDefault().TotalRecordCount = totalrecord + 1;
                }
            }
            return record;
        }


        public List<StopPayCharge_VM_Download> GetCustomerStopPayChargeDawnload(CustomerSummary_VM customerSummary_VM)
        {
            List<StopPayCharge_VM_Download> record = new List<StopPayCharge_VM_Download>();
            if (string.IsNullOrEmpty(customerSummary_VM.search) == true)
            {
                record = stopPayCharge.StopCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate
                && w.Dateactive <= customerSummary_VM.Enddate).Select(s => new StopPayCharge_VM_Download
                {
                    Acct = s.Acct,
                    Branch = s.Branch,
                    CheckNumber = s.CheckNumber,
                    Cif = s.Cif,
                    Dateactive = s.Dateactive.Value.ToString("MM/dd/yyyy"),
                    NationalFees = s.NationalFees,
                    ProofSequence = s.ProofSequence,
                    StopchargeId = s.StopchargeId,
                    TransAmt =Convert.ToString(s.TransAmt),
                    Transcode = s.Transcode,
                    Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),

                }).ToList();
            }
            else
            {
                record = stopPayCharge.StopCharges.Where(w => w.Acct == customerSummary_VM.acct.ToString() && w.Dateactive >= customerSummary_VM.Startdate
                && w.Dateactive <= customerSummary_VM.Enddate && (w.Cif.Contains(customerSummary_VM.search) || w.Acct.Contains(customerSummary_VM.search) ||
                w.Dateactive.ToString().Contains(customerSummary_VM.search) || w.Branch.Contains(customerSummary_VM.search) || w.ProofSequence.Contains(customerSummary_VM.search) ||
                w.CheckNumber.Contains(customerSummary_VM.search) || w.TransAmt.ToString().Contains(customerSummary_VM.search) || w.NationalFees.ToString().Contains(customerSummary_VM.search)
                || w.Vat.ToString().Contains(customerSummary_VM.search))).Select(s => new StopPayCharge_VM_Download
                {
                    Acct = s.Acct,
                    Branch = s.Branch,
                    CheckNumber = s.CheckNumber,
                    Cif = s.Cif,
                    Dateactive = s.Dateactive.Value.ToString("MM/dd/yyyy"),
                    NationalFees = s.NationalFees,
                    ProofSequence = s.ProofSequence,
                    StopchargeId = s.StopchargeId,
                    TransAmt =Convert.ToString(s.TransAmt),
                    Transcode = s.Transcode,
                    Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),

                }).ToList();
            }
            if (record.Count > 0)
            {
                record.Add(new StopPayCharge_VM_Download
                {
                    CheckNumber = "Total:",
                    TransAmt = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.TransAmt))),
                    NationalFees = record.Sum(s => s.NationalFees),
                    Vat = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat))),
                });
                //ulong totalrecord = (ulong)record.Count();
                //record.FirstOrDefault().TotalRecordCount = totalrecord;
            }
            return record;
        }
        public List<StopPayCharge_VM> GetStopPayCharge(Summery_VM summery_VM, [Optional] int pageNum, [Optional] int recordPerPage)
        {
            List<StopPayCharge_VM> record = new List<StopPayCharge_VM>();
            if (string.IsNullOrEmpty(summery_VM.search) == true)
            {
                record = stopPayCharge.StopCharges.Where(w => w.Branch == summery_VM.Branch.ToString() &&
                w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo).Select(s => new StopPayCharge_VM
                {
                    Acct = s.Acct,
                    Branch = s.Branch,
                    Dateactive = s.Dateactive,
                    CheckNumber = s.CheckNumber,
                    Cif = s.Cif,
                    NationalFees = String.Format("{0:0.00}",Convert.ToDouble(s.NationalFees)),
                    ProofSequence = s.ProofSequence,
                    StopchargeId = s.StopchargeId,
                    TransAmt =String.Format("{0:0.00}",Convert.ToDouble(s.TransAmt)),
                    Transcode = s.Transcode,
                    Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),
                }).ToList();
                if (record.Count() > 0)
                {
                    record.Add(new StopPayCharge_VM
                    {
                        CheckNumber = "Totals:",
                        TransAmt = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.TransAmt))),
                        NationalFees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.NationalFees))),
                        Vat = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat)))
                    });
                    record = record.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                    ulong totalrecord = (ulong)stopPayCharge.StopCharges.Where(w => w.Branch == summery_VM.Branch.ToString() &&
                     w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo).Count();
                    record.FirstOrDefault().TotalRecordCount = totalrecord+1;
                }

            }
            else
            {
                record = stopPayCharge.StopCharges.Where(w => w.Branch == summery_VM.Branch.ToString() &&
                w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo && (w.Cif.Contains(summery_VM.search) ||
                w.Acct.Contains(summery_VM.search) || w.Dateactive.ToString().Contains(summery_VM.search) || w.Branch.Contains(summery_VM.search) ||
                w.ProofSequence.Contains(summery_VM.search) || w.CheckNumber.Contains(summery_VM.search) && w.TransAmt.ToString().Contains(summery_VM.search) ||
                w.NationalFees.ToString().Contains(summery_VM.search) || w.Vat.ToString().Contains(summery_VM.search))).Select(s => new StopPayCharge_VM
                {
                    Acct = s.Acct,
                    Branch = s.Branch,
                    Dateactive = s.Dateactive,
                    CheckNumber = s.CheckNumber,
                    Cif = s.Cif,
                    NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                    ProofSequence = s.ProofSequence,
                    StopchargeId = s.StopchargeId,
                    TransAmt = String.Format("{0:0.00}", Convert.ToDouble(s.TransAmt)),
                    Transcode = s.Transcode,
                    Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),
                }).ToList();
                if (record.Count() > 0)
                {
                    record.Add(new StopPayCharge_VM
                    {
                        CheckNumber = "Totals:",
                        TransAmt = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.TransAmt))),
                        NationalFees = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.NationalFees))),
                        Vat = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat)))
                    });
                    ulong totalrecord = (ulong)stopPayCharge.StopCharges.Where(w => w.Branch == summery_VM.Branch.ToString() &&
                    w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo && (w.Cif.Contains(summery_VM.search) ||
                    w.Acct.Contains(summery_VM.search) || w.Dateactive.ToString().Contains(summery_VM.search) || w.Branch.Contains(summery_VM.search) ||
                    w.ProofSequence.Contains(summery_VM.search) || w.CheckNumber.Contains(summery_VM.search) && w.TransAmt.ToString().Contains(summery_VM.search) ||
                    w.NationalFees.ToString().Contains(summery_VM.search) || w.Vat.ToString().Contains(summery_VM.search))).Count();
                    record.FirstOrDefault().TotalRecordCount = totalrecord+1;
                }
            }
            return record;
        }

        public List<StopPayCharge_VM_Download> GetStopPayChargeDawnload(Summery_VM summery_VM)
        {
            List<StopPayCharge_VM_Download> record = new List<StopPayCharge_VM_Download>();
            if (string.IsNullOrEmpty(summery_VM.search) == true)
            {
                record = stopPayCharge.StopCharges.Where(w => w.Branch == summery_VM.Branch.ToString() &&
                w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo).Select(s => new StopPayCharge_VM_Download
                {
                    Acct = s.Acct,
                    Branch = s.Branch,
                    Dateactive = s.Dateactive.Value.ToString("MM/dd/yyyy"),
                    CheckNumber = s.CheckNumber,
                    Cif = s.Cif,
                    NationalFees = s.NationalFees,
                    ProofSequence = s.ProofSequence,
                    StopchargeId = s.StopchargeId,
                    TransAmt = String.Format("{0:0.00}", Convert.ToDouble(s.TransAmt)),
                    Transcode = s.Transcode,
                    Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),
                }).ToList();
            }
            else
            {
                record = stopPayCharge.StopCharges.Where(w => w.Branch == summery_VM.Branch.ToString() &&
                w.Dateactive >= summery_VM.dateFrom && w.Dateactive <= summery_VM.DateTo && (w.Cif.Contains(summery_VM.search) ||
                w.Acct.Contains(summery_VM.search) || w.Dateactive.ToString().Contains(summery_VM.search) || w.Branch.Contains(summery_VM.search) ||
                w.ProofSequence.Contains(summery_VM.search) || w.CheckNumber.Contains(summery_VM.search) && w.TransAmt.ToString().Contains(summery_VM.search) ||
                w.NationalFees.ToString().Contains(summery_VM.search) || w.Vat.ToString().Contains(summery_VM.search))).Select(s => new StopPayCharge_VM_Download
                {
                    Acct = s.Acct,
                    Branch = s.Branch,
                    Dateactive = s.Dateactive.Value.ToString("MM/dd/yyyy"),
                    CheckNumber = s.CheckNumber,
                    Cif = s.Cif,
                    NationalFees = s.NationalFees,
                    ProofSequence = s.ProofSequence,
                    StopchargeId = s.StopchargeId,
                    TransAmt =String.Format("{0:0.00}", Convert.ToDouble(s.TransAmt)),
                    Transcode = s.Transcode,
                    Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat)),
                }).ToList();
            }
            if (record.Count() > 0)
            {
                record.Add(new StopPayCharge_VM_Download
                {
                    CheckNumber = "Totals:",
                    // String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Totalfees)))
                    TransAmt= String.Format("{0:0.00}", record.Sum(s =>Convert.ToDouble(s.TransAmt))),
                    //TransAmt = record.Sum(s => s.TransAmt),
                    NationalFees = record.Sum(s => s.NationalFees),
                    Vat = String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Vat))),
                });
                //ulong totalrecord = (ulong)record.Count();
                //record.FirstOrDefault().TotalRecordCount = totalrecord;
            }

            return record;
        }
    }
}
