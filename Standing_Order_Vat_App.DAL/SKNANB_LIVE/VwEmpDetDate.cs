using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VwEmpDetDate
    {
        public string? StaffNo { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfJoin { get; set; }
        public DateTime? PensionSchemeJoin { get; set; }
        public DateTime? EndOfProbation { get; set; }
        public string EndOfContract { get; set; } = null!;
        public DateTime? DateOfLeaving { get; set; }
    }
}
