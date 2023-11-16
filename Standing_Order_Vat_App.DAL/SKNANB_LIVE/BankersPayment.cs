using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class BankersPayment
    {
        public DateTime? Date { get; set; }
        public string? Payee { get; set; }
        public long? Number { get; set; }
        public string? Bank { get; set; }
        public decimal? Debit { get; set; }
        public DateTime? DateCleared { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Balance { get; set; }
        public bool? DeleteFlg { get; set; }
        public string? TheUser { get; set; }
        public string? UserMachine { get; set; }
        public int Key { get; set; }
    }
}
