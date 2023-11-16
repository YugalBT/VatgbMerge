using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class PayrollCustomReport
    {
        public string ReportName { get; set; } = null!;
        public string ReportSp { get; set; } = null!;
        public string? Description { get; set; }
    }
}
