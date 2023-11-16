using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB;
using System.Runtime.InteropServices;

namespace Standing_Order_Vat_App.Common.Services
{
    public class SafekeepingPaymentservice : ISafekeepingPayments
    {
        private readonly Standing_Order_VATContext safekeepingPayments;

        public SafekeepingPaymentservice(Standing_Order_VATContext safekeepingPayments)
        {
            this.safekeepingPayments = safekeepingPayments;
        }


        public List<SafekeepingPayment_VM> getCustomerSafekeepingPayments(CustomerSummary_VM customerSummary_VM, [Optional] int pageNum, [Optional] int recordPerPage)
        {
            List<SafekeepingPayment_VM> recored = new List<SafekeepingPayment_VM>();

            if (string.IsNullOrEmpty(customerSummary_VM.search) == true)
            {
                recored = safekeepingPayments.SafeKeepingPayments.Where(w => w.Acct == customerSummary_VM.acct.ToString() &&
                w.Dateactive >= customerSummary_VM.Startdate && w.Dateactive <= customerSummary_VM.Enddate).Select(s => new SafekeepingPayment_VM
                {
                    Acct = s.Acct,
                    Branch = s.Branch,
                    CheckNumber = s.CheckNumber,
                    Cif = s.Cif,
                    Dateactive = s.Dateactive,
                    NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                    ProofSequence = s.ProofSequence,
                    SafeKeepingId = s.SafeKeepingId,
                    Transamt =String.Format("{0:0.00}", Convert.ToDouble(s.Transamt)),
                    Transcode = s.Transcode,
                    Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                }).ToList();
                if (recored.Count > 0)
                {
                    recored.Add(new SafekeepingPayment_VM
                    {
                        CheckNumber = "Totals:",
                        Transamt = String.Format("{0:0.00}", recored.Sum(s => Convert.ToDouble(s.Transamt))),
                        NationalFees = String.Format("{0:0.00}", recored.Sum(s => Convert.ToDouble(s.NationalFees))),
                        Vat =String.Format("{0:0.00}", recored.Sum(s => Convert.ToDouble(s.Vat)))
                    });
                    recored=recored.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                    ulong totalcount = (ulong)safekeepingPayments.SafeKeepingPayments.Where(w => w.Acct == customerSummary_VM.acct.ToString() &&
                  w.Dateactive >= customerSummary_VM.Startdate && w.Dateactive <= customerSummary_VM.Enddate).Count();
                    recored.FirstOrDefault().TotalRecordCount = totalcount+1;
                }
            }
            else
            {
                recored = safekeepingPayments.SafeKeepingPayments.Where(w => w.Acct == customerSummary_VM.acct.ToString() &&
                w.Dateactive >= customerSummary_VM.Startdate && w.Dateactive <= customerSummary_VM.Enddate && (w.Cif.Contains(customerSummary_VM.search) ||
                w.Acct.Contains(customerSummary_VM.search) || w.Dateactive.ToString().Contains(customerSummary_VM.search) || w.Branch.Contains(customerSummary_VM.search)
                || w.ProofSequence.Contains(customerSummary_VM.search) || w.CheckNumber.Contains(customerSummary_VM.search) || w.Transamt.ToString().Contains(customerSummary_VM.search) ||
                w.NationalFees.ToString().Contains(customerSummary_VM.search) || w.Vat.ToString().Contains(customerSummary_VM.search))).Select(s => new SafekeepingPayment_VM
                {
                    Acct = s.Acct,
                    Branch = s.Branch,
                    CheckNumber = s.CheckNumber,
                    Cif = s.Cif,
                    Dateactive = s.Dateactive,
                    NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                    ProofSequence = s.ProofSequence,
                    SafeKeepingId = s.SafeKeepingId,
                    Transamt = String.Format("{0:0.00}", Convert.ToDouble(s.Transamt)),
                    Transcode = s.Transcode,
                    Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                }).ToList();
                if (recored.Count > 0)
                {
                    recored.Add(new SafekeepingPayment_VM
                    {
                        CheckNumber = "Totals:",
                        Transamt = String.Format("{0:0.00}", recored.Sum(s => Convert.ToDouble(s.Transamt))),
                        NationalFees = String.Format("{0:0.00}", recored.Sum(s => Convert.ToDouble(s.NationalFees))),
                        Vat = String.Format("{0:0.00}", recored.Sum(s => Convert.ToDouble(s.Vat)))
                    });
                    recored = recored.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                    ulong totalcount = (ulong)safekeepingPayments.SafeKeepingPayments.Where(w => w.Acct == customerSummary_VM.acct.ToString() &&
                  w.Dateactive >= customerSummary_VM.Startdate && w.Dateactive <= customerSummary_VM.Enddate).Count();
                    recored.FirstOrDefault().TotalRecordCount = totalcount+1;
                }
            }
            return recored;
        }

        public List<SafekeepingPayment_VM_Download> getCustomerSafekeepingPaymentsDawnload(CustomerSummary_VM customerSummary_VM)
        {
            List<SafekeepingPayment_VM_Download> recored = new List<SafekeepingPayment_VM_Download>();
            if (string.IsNullOrEmpty(customerSummary_VM.search) == true)
            {
                recored = safekeepingPayments.SafeKeepingPayments.Where(w => w.Acct == customerSummary_VM.acct.ToString() &&
                w.Dateactive >= customerSummary_VM.Startdate && w.Dateactive <= customerSummary_VM.Enddate).Select(s => new SafekeepingPayment_VM_Download
                {
                    Acct = s.Acct,
                    Branch = s.Branch,
                    CheckNumber = s.CheckNumber,
                    Cif = s.Cif,
                    Dateactive = s.Dateactive.Value.ToString("MM/dd/yyyy"),
                    NationalFees = s.NationalFees,
                    ProofSequence = s.ProofSequence,
                    SafeKeepingId = s.SafeKeepingId,
                    Transamt = String.Format("{0:0.00}", Convert.ToDouble(s.Transamt)),
                    Transcode = s.Transcode,
                    Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                }).ToList();
            }
            else
            {
                recored = safekeepingPayments.SafeKeepingPayments.Where(w => w.Acct == customerSummary_VM.acct.ToString() &&
                w.Dateactive >= customerSummary_VM.Startdate && w.Dateactive <= customerSummary_VM.Enddate && (w.Cif.Contains(customerSummary_VM.search) ||
                w.Acct.Contains(customerSummary_VM.search) || w.Dateactive.ToString().Contains(customerSummary_VM.search) || w.Branch.Contains(customerSummary_VM.search)
                || w.ProofSequence.Contains(customerSummary_VM.search) || w.CheckNumber.Contains(customerSummary_VM.search) || w.Transamt.ToString().Contains(customerSummary_VM.search) ||
                w.NationalFees.ToString().Contains(customerSummary_VM.search) || w.Vat.ToString().Contains(customerSummary_VM.search))).Select(s => new SafekeepingPayment_VM_Download
                {
                    Acct = s.Acct,
                    Branch = s.Branch,
                    CheckNumber = s.CheckNumber,
                    Cif = s.Cif,
                    Dateactive = s.Dateactive.Value.ToString("MM/dd/yyyy"),
                    NationalFees = s.NationalFees,
                    ProofSequence = s.ProofSequence,
                    SafeKeepingId = s.SafeKeepingId,
                    Transamt = String.Format("{0:0.00}", Convert.ToDouble(s.Transamt)),
                    Transcode = s.Transcode,
                    Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                }).ToList();
            }
            if (recored.Count > 0)
            {
                recored.Add(new SafekeepingPayment_VM_Download
                {
                  CheckNumber="Totals:",
                    // String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Totalfees)))

                    Transamt = String.Format("{0:0.00}", recored.Sum(s=>Convert.ToDouble(s.Transamt))),
                   NationalFees=recored.Sum(s=>s.NationalFees),
                   Vat=String.Format("{0:0.00}", recored.Sum(s => Convert.ToDouble(s.Vat)))
                });
                //ulong totalcount = (ulong)recored.Count();

                //recored.FirstOrDefault().TotalRecordCount = totalcount;
            }
            return recored;
        }
        public List<SafekeepingPayment_VM> getSafekeepingPayments(Summery_VM vm, [Optional] int pageNum, [Optional] int recordPerPage)
        {
            List<SafekeepingPayment_VM> recored = new List<SafekeepingPayment_VM>();
            if (string.IsNullOrEmpty(vm.search) == true)
            {
                recored = safekeepingPayments.SafeKeepingPayments.Where(w => w.Branch == vm.Branch.ToString()
                 && w.Dateactive >= vm.dateFrom && w.Dateactive <= vm.DateTo).Select(s => new SafekeepingPayment_VM
                 {
                     Acct = s.Acct,
                     Branch = s.Branch,
                     CheckNumber = s.CheckNumber,
                     Cif = s.Cif,
                     Dateactive = s.Dateactive,
                     NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                     ProofSequence = s.ProofSequence,
                     SafeKeepingId = s.SafeKeepingId,
                     Transamt = String.Format("{0:0.00}", Convert.ToDouble(s.Transamt)),
                     Transcode = s.Transcode,
                     Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                 }).ToList();
                if (recored.Count > 0)
                {
                    recored.Add(new SafekeepingPayment_VM
                    {
                        Branch = "Totals:",
                        Transamt = String.Format("{0:0.00}", recored.Sum(s => Convert.ToDouble(s.Transamt))),
                        NationalFees = String.Format("{0:0.00}", recored.Sum(s => Convert.ToDouble(s.NationalFees))),
                        Vat = String.Format("{0:0.00}", recored.Sum(s => Convert.ToDouble(s.Vat)))
                    });
                    recored=recored.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                }
            }
            else
            {
                recored = safekeepingPayments.SafeKeepingPayments.Where(w => w.Branch == vm.Branch.ToString()
                 && w.Dateactive >= vm.dateFrom && w.Dateactive <= vm.DateTo && (w.Cif.Contains(vm.search) || w.Acct.Contains(vm.search) ||
                 w.Dateactive.ToString().Contains(vm.search) || w.Transamt.ToString().Contains(vm.search) || w.Branch.Contains(vm.search)
                 || w.NationalFees.ToString().Contains(vm.search) || w.Vat.ToString().Contains(vm.search))).Select(s => new SafekeepingPayment_VM
                 {
                     Acct = s.Acct,
                     Branch = s.Branch,
                     CheckNumber = s.CheckNumber,
                     Cif = s.Cif,
                     Dateactive = s.Dateactive,
                     NationalFees = String.Format("{0:0.00}", Convert.ToDouble(s.NationalFees)),
                     ProofSequence = s.ProofSequence,
                     SafeKeepingId = s.SafeKeepingId,
                     Transamt = String.Format("{0:0.00}", Convert.ToDouble(s.Transamt)),
                     Transcode = s.Transcode,
                     Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                 }).ToList();
                if (recored.Count > 0)
                {
                    recored.Add(new SafekeepingPayment_VM
                    {
                        Branch = "Totals:",
                        // String.Format("{0:0.00}", record.Sum(s => Convert.ToDouble(s.Totalfees)))
                        Transamt= String.Format("{0:0.00}", recored.Sum(s =>Convert.ToDouble(s.Transamt))),
                        //Transamt = recored.Sum(s => s.Transamt),
                        NationalFees = String.Format("{0:0.00}", recored.Sum(s => Convert.ToDouble(s.NationalFees))),
                        Vat = String.Format("{0:0.00}", recored.Sum(s => Convert.ToDouble(s.Vat)))
                    });
                    recored = recored.Skip(pageNum * recordPerPage).Take(recordPerPage).ToList();
                }
            }
            if (recored.Count > 0)
            {
                ulong totalrecord = 0;
                if (string.IsNullOrEmpty(vm.search) == true)
                {
                    totalrecord = (ulong)safekeepingPayments.SafeKeepingPayments.Where(w => w.Branch == vm.Branch.ToString()
             && w.Dateactive >= vm.dateFrom && w.Dateactive <= vm.DateTo).Count();
                }
                else
                {
                    totalrecord = (ulong)safekeepingPayments.SafeKeepingPayments.Where(w => w.Branch == vm.Branch.ToString()
                 && w.Dateactive >= vm.dateFrom && w.Dateactive <= vm.DateTo && (w.Cif.Contains(vm.search) || w.Acct.Contains(vm.search) ||
                 w.Dateactive.ToString().Contains(vm.search) || w.Transamt.ToString().Contains(vm.search) || w.Branch.Contains(vm.search)
                 || w.NationalFees.ToString().Contains(vm.search) || w.Vat.ToString().Contains(vm.search))).Count();
                }
                recored.FirstOrDefault().TotalRecordCount = totalrecord+1;
            }

            return recored;
        }

        public List<SafekeepingPayment_VM_Download> getSafekeepingPaymentsDawnload(Summery_VM vm)
        {
            List<SafekeepingPayment_VM_Download> recored = new List<SafekeepingPayment_VM_Download>();
            if (string.IsNullOrEmpty(vm.search) == true)
            {
                recored = safekeepingPayments.SafeKeepingPayments.Where(w => w.Branch == vm.Branch.ToString()
                 && w.Dateactive >= vm.dateFrom && w.Dateactive <= vm.DateTo).Select(s => new SafekeepingPayment_VM_Download
                 {
                     Acct = s.Acct,
                     Branch = s.Branch,
                     CheckNumber = s.CheckNumber,
                     Cif = s.Cif,
                     Dateactive = s.Dateactive.Value.ToString("MM/dd/yyyy"),
                     NationalFees = s.NationalFees,
                     ProofSequence = s.ProofSequence,
                     SafeKeepingId = s.SafeKeepingId,
                     Transamt = String.Format("{0:0.00}", Convert.ToDouble(s.Transamt)),
                     Transcode = s.Transcode,
                     Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                 }).ToList();
            }
            else
            {
                recored = safekeepingPayments.SafeKeepingPayments.Where(w => w.Branch == vm.Branch.ToString()
                 && w.Dateactive >= vm.dateFrom && w.Dateactive <= vm.DateTo && (w.Cif.Contains(vm.search) || w.Acct.Contains(vm.search) ||
                 w.Dateactive.ToString().Contains(vm.search) || w.Transamt.ToString().Contains(vm.search) || w.Branch.Contains(vm.search)
                 || w.NationalFees.ToString().Contains(vm.search) || w.Vat.ToString().Contains(vm.search))).Select(s => new SafekeepingPayment_VM_Download
                 {
                     Acct = s.Acct,
                     Branch = s.Branch,
                     CheckNumber = s.CheckNumber,
                     Cif = s.Cif,
                     Dateactive = s.Dateactive.Value.ToString("MM/dd/yyyy"),
                     NationalFees = s.NationalFees,
                     ProofSequence = s.ProofSequence,
                     SafeKeepingId = s.SafeKeepingId,
                     Transamt = String.Format("{0:0.00}", Convert.ToDouble(s.Transamt)),
                     Transcode = s.Transcode,
                     Vat = String.Format("{0:0.00}", Convert.ToDouble(s.Vat))
                 }).ToList();
            }
            if (recored.Count > 0)
            {
                recored.Add(new SafekeepingPayment_VM_Download
                {
                    Branch = "Totals:",
                    Transamt = String.Format("{0:0.00}", recored.Sum(s => Convert.ToDouble(s.Transamt))),
                    NationalFees = recored.Sum(s => s.NationalFees),
                    Vat = String.Format("{0:0.00}", recored.Sum(s => Convert.ToDouble(s.Vat)))
                });
                //ulong totalrecord = (ulong)recored.Count();
                //recored.FirstOrDefault().TotalRecordCount = totalrecord;
            }
            
            return recored;
        }
    }
}
