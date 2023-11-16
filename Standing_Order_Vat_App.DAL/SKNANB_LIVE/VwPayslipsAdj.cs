using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VwPayslipsAdj
    {
        public int AdjPmtId { get; set; }
        public int PaymentId { get; set; }
        public int TypeId { get; set; }
        public decimal Amount { get; set; }
        public decimal NetAmount { get; set; }
        public string? Comment { get; set; }
        public int? SourceGl { get; set; }
        public int? DepositAccount { get; set; }
    }
}
