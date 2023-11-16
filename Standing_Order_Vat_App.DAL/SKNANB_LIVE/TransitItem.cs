using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class TransitItem
    {
        public long? ChequeNumber { get; set; }
        public DateTime? Date { get; set; }
        public string? Payee { get; set; }
        public string? Bank { get; set; }
        public string? Currency { get; set; }
        public decimal? DebitForeignAmount { get; set; }
        public decimal? DebitEcEquivalent { get; set; }
        public DateTime? DateCleared { get; set; }
        public decimal? CreditForeignAmount { get; set; }
        public decimal? CreditEcEquivalent { get; set; }
        public decimal? Balance { get; set; }
        public bool? DeleteFlg { get; set; }
        public string? TheUser { get; set; }
        public string? TheMachine { get; set; }
        public int RecId { get; set; }
        public bool? Cleared { get; set; }
        public int? BranchId { get; set; }
    }
}
