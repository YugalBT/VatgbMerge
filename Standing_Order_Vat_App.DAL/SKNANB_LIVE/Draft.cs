using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class Draft
    {
        public DateTime? Date { get; set; }
        public long? DraftNumber { get; set; }
        public string? Payee { get; set; }
        public string? Purchaser { get; set; }
        public string? BanKdrawnOn { get; set; }
        public string? Currency { get; set; }
        public decimal? Amount { get; set; }
        public bool? BankCustomer { get; set; }
        public string? PaymentType { get; set; }
        public bool? DeleteFlg { get; set; }
        public string? TheUser { get; set; }
        public string? UserMachine { get; set; }
    }
}
