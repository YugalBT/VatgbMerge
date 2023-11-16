using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.GB_Register
{
    public partial class ForeignChecksSettlement
    {
        public long SettlementId { get; set; }
        public string? CheckNumber { get; set; }
        public decimal SettlementAmount { get; set; }
        public long BatchId { get; set; }
        public DateTime DateSettled { get; set; }
        public string? SettledByWire { get; set; }
        public int? CorrespondentBankId { get; set; }

        public virtual ForeignChecksBatch Batch { get; set; } = null!;
    }
}
