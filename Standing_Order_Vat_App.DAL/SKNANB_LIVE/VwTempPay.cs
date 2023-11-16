using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VwTempPay
    {
        public int IdPayment { get; set; }
        public int IdEmployee { get; set; }
        public decimal MnyNetPay { get; set; }
        public DateTime? DtPaid { get; set; }
        public int? IdType { get; set; }
        public string? TxComment { get; set; }
        public int? IdHistory { get; set; }
        public int IdCompany { get; set; }
        public int? IdSocialSec { get; set; }
        public string? AcPay { get; set; }
        public int? IdAcctType { get; set; }
    }
}
