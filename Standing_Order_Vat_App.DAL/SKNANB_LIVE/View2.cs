using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class View2
    {
        public int? SocialSecurity { get; set; }
        public string? TxReasons { get; set; }
        public int? TotalDays { get; set; }
        public DateTime? DtStart { get; set; }
        public DateTime? DtEnd { get; set; }
    }
}
