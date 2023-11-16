using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class AttendanceSummary
    {
        public int? EmpId { get; set; }
        public double? AvailableSd { get; set; }
        public double? AvailableVac { get; set; }
        public int? TheYear { get; set; }
        public double? VacOwing { get; set; }
        public DateTime? ProdDate { get; set; }
        public int? Entitlement { get; set; }
    }
}
