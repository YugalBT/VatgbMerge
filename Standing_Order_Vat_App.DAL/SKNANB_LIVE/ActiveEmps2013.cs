using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class ActiveEmps2013
    {
        public int? IdSocialSec { get; set; }
        public string? NmFirst { get; set; }
        public string? NmLast { get; set; }
        public string InInactive { get; set; } = null!;
        public int IdCompany { get; set; }
        public int IdBranch { get; set; }
    }
}
