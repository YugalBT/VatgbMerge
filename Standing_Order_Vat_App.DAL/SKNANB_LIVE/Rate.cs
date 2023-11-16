using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class Rate
    {
        public string CurrencyType { get; set; } = null!;
        public decimal EcRate { get; set; }
        public DateTime Date { get; set; }
        public int Key { get; set; }
        public string? TheUser { get; set; }
    }
}
