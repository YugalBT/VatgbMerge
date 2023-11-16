using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class ForeignCheckBatchVm
    {
        public long BatchId { get; set; }
        public DateTime? DatePaymentRequested { get; set; }
        public decimal? BatchTotal { get; set; }
        public DateTime? DateSettled { get; set; }
        public int BankId { get; set; }
        public int BatchStatusId { get; set; }
        public int? ProcessedByIdEmployee { get; set; }
        public int? SettledByIdEmployee { get; set; }
        public string? BranchNumber { get; set; }
        public DateTime? DateProcessed { get; set; }
        public DateTime? DateReceived { get; set; }
        public string CheckNumber { get; set; } = null!;
        public string PayerAcctNumber { get; set; } = null!;
        public string PayerAcctName { get; set; } = null!;
        public string DepositAcctNumber { get; set; } = null!;
        public string DepositAcctName { get; set; } = null!;

        public decimal CheckAmount { get; set; }

    }
}
