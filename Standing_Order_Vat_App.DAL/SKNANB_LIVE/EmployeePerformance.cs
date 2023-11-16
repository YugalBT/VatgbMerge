using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class EmployeePerformance
    {
        public int EmployeePerformanceId { get; set; }
        public int? EmployeeHistoryId { get; set; }
        public int EmployeeId { get; set; }
        public int AssessmentYear { get; set; }
        public int AssessmentPoints { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; } = null!;

        public virtual Employee Employee { get; set; } = null!;
    }
}
