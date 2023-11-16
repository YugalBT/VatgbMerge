using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class ReportSetup
    {
        public short Setupkey { get; set; }
        public string ReportUrl { get; set; } = null!;
        public string NextReportFileName { get; set; } = null!;
        public short Xprtftyp { get; set; }
        public int DexRowId { get; set; }
    }
}
