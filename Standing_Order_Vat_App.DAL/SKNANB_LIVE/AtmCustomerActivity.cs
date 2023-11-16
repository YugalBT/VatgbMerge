using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class AtmCustomerActivity
    {
        public DateTime? DateAndTime { get; set; }
        public string? Machine { get; set; }
        public int? AtmNumber { get; set; }
        public string? CardNumber { get; set; }
        public string? TransactionNumber { get; set; }
        public string? Activity { get; set; }
        public string? FromAccount { get; set; }
        public string? ToAccount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Balance { get; set; }
        public string? Error { get; set; }
        public string? RecSolution { get; set; }
        public long TranId { get; set; }
    }
}
