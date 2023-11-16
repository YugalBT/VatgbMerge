using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class CurrSal
    {
        public string? NmFirst { get; set; }
        public string? NmLast { get; set; }
        public DateTime DtPaid { get; set; }
        public decimal MnyNetPay { get; set; }
    }
}
