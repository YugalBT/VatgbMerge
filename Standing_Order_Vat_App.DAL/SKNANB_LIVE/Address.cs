using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class Address
    {
        public int IdAddress { get; set; }
        public int IdProfile { get; set; }
        public string? TxAddr1 { get; set; }
        public string? TxAddr2 { get; set; }
        public string? NmCity { get; set; }
        public string? NmCountry { get; set; }
        public string? PhPhone1 { get; set; }
        public string? InDelFlg { get; set; }
        public string? PhPhone2 { get; set; }
        public string? CdZip { get; set; }

        public virtual Profile IdProfileNavigation { get; set; } = null!;
    }
}
