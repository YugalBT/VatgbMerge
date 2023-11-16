using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class TestView
    {
        public string? NmFirst { get; set; }
        public string? NmLast { get; set; }
        public string InInactive { get; set; } = null!;
        public DateTime? DtHired { get; set; }
        public int? IdGrade { get; set; }
        public decimal? MnyPayReg { get; set; }
        public int? AcPay { get; set; }
        public DateTime? DtDob { get; set; }
        public decimal? MnyPayMonth { get; set; }
    }
}
