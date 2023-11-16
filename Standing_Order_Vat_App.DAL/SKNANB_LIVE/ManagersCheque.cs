using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class ManagersCheque
    {
        public long? ChequeNumber { get; set; }
        public DateTime? Date { get; set; }
        public string? Payee { get; set; }
        public string? Purchaser { get; set; }
        public decimal? Amount { get; set; }
        public bool? BankCustomer { get; set; }
        public string? PaymentType { get; set; }
        public DateTime? DateCleared { get; set; }
        public string? BankFirstPresented { get; set; }
        public decimal Balance { get; set; }
        public bool Cleared { get; set; }
        public bool? DeleteFlg { get; set; }
        public string? TheUser { get; set; }
        public string? TheMachine { get; set; }
        public int? MPmntId { get; set; }
        public int? BranchId { get; set; }
    }
}
