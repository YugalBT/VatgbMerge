using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VwEmpDetailsContract
    {
        public string? StaffNo { get; set; }
        public string Division { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string? JobTitle { get; set; }
        public int? Grade { get; set; }
        public string Location { get; set; } = null!;
        public string Assistant { get; set; } = null!;
        public string FullPartTime { get; set; } = null!;
        public string NoticePeriod { get; set; } = null!;
        public string? Satus { get; set; }
    }
}
