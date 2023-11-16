using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VwHorizon55
    {
        public int IdCard { get; set; }
        public int IdProfile { get; set; }
        public string MemberName { get; set; } = null!;
        public bool CardIssued { get; set; }
        public DateTime? DateLoaded { get; set; }
        public string? Account1 { get; set; }
        public string? Account2 { get; set; }
        public string? AccountType { get; set; }
        public bool Processed { get; set; }
    }
}
