using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class CardCustomReport
    {
        public string ReportName { get; set; } = null!;
        public string ReportSp { get; set; } = null!;
        public string? Description { get; set; }
    }
}
