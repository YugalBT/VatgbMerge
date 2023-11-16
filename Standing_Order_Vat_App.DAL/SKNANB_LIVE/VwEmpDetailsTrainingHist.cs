using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VwEmpDetailsTrainingHist
    {
        public string? StaffNo { get; set; }
        public string Identifier { get; set; } = null!;
        public string Course { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Provider { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Cost { get; set; } = null!;
        public string ExpiryDate { get; set; } = null!;
        public string Duration { get; set; } = null!;
        public string Passed { get; set; } = null!;
        public string Assesment { get; set; } = null!;
        public string Notes { get; set; } = null!;
    }
}
