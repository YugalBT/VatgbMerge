using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VwEmployeeDetail
    {
        public string? StaffNo { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string MiddleName { get; set; } = null!;
        public string KnownAs { get; set; } = null!;
        public string? Title { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Address4 { get; set; }
        public string Address5 { get; set; } = null!;
        public string Company { get; set; } = null!;
    }
}
