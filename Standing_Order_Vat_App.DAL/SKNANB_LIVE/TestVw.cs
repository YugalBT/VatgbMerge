using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class TestVw
    {
        public string? NmFirst { get; set; }
        public string? NmLast { get; set; }
        public int? IdSocialSec { get; set; }
        public DateTime? DtHired { get; set; }
        public string DepName { get; set; } = null!;
    }
}
