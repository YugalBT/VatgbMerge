using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.GB_Register
{
    public partial class ForeignChecksBatch
    {
        public ForeignChecksBatch()
        {
            ForeignChecksDetails = new HashSet<ForeignChecksDetail>();
            ForeignChecksSettlements = new HashSet<ForeignChecksSettlement>();
        }

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

        public virtual EntryStatus BatchStatus { get; set; } = null!;
        public virtual ICollection<ForeignChecksDetail> ForeignChecksDetails { get; set; }
        public virtual ICollection<ForeignChecksSettlement> ForeignChecksSettlements { get; set; }
    }
}
