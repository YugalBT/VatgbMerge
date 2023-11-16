using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class StaffPerformanceHistory
    {
        public int IdPerformance { get; set; }
        public int IdEmployee { get; set; }
        public int AssessmentYear { get; set; }
        public int AssessmentQuarter { get; set; }
        public DateTime AssessmentDate { get; set; }
        public decimal JobFactorsScore { get; set; }
        public decimal PerformanceFactorsScore { get; set; }
        public decimal OverallScore { get; set; }
        public string OverallRating { get; set; } = null!;

        public virtual Employee IdEmployeeNavigation { get; set; } = null!;
    }
}
