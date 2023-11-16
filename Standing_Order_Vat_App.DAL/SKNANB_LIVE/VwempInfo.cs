using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VwempInfo
    {
        public string? NmFirst { get; set; }
        public string? NmLast { get; set; }
        public int? IdSocialSec { get; set; }
        public DateTime? DtHired { get; set; }
        public string TypeName { get; set; } = null!;
        public int? TheYear { get; set; }
        public string InInactive { get; set; } = null!;
        public string InIsStaff { get; set; } = null!;
    }
}
