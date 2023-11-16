using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VwEmpDetailsPaydatum
    {
        public string? StaffNo { get; set; }
        public DateTime FromDate { get; set; }
        public decimal Pay { get; set; }
        public string PayBasis { get; set; } = null!;
        public DateTime PayPeriod { get; set; }
        public string ContractualHours { get; set; } = null!;
        public decimal OverTime { get; set; }
    }
}
