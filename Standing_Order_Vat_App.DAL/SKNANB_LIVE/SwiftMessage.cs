using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class SwiftMessage
    {
        public DateTime? Date { get; set; }
        public int? MessageReferenceNumber { get; set; }
        public string? MessageType { get; set; }
        public string? Sender { get; set; }
        public int? TransactionReference { get; set; }
        public DateTime? ValueDate { get; set; }
        public string? Currency { get; set; }
        public decimal? Amount { get; set; }
        public string? OrderingCustomer { get; set; }
        public string? BeneficiaryBank { get; set; }
        public string? BeneficiaryCustomer { get; set; }
        public bool? BankCustomer { get; set; }
        public DateTime? DateEntryPassed { get; set; }
        public string? Particulars { get; set; }
        public string? Direction { get; set; }
        public string? Comments { get; set; }
    }
}
