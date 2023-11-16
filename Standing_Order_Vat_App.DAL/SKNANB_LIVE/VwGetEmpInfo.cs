using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VwGetEmpInfo
    {
        public int IdEmployee { get; set; }
        public string? NmFirst { get; set; }
        public string? NmLast { get; set; }
        public int? IdSocialSec { get; set; }
        public string InInactive { get; set; } = null!;
        public DateTime? DtEndProb { get; set; }
        public string NmCompany { get; set; } = null!;
        public DateTime? DtHired { get; set; }
        public string InIsStaff { get; set; } = null!;
    }
}
