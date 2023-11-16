using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class SvcAbcd
    {
        public string RtvNumber { get; set; } = null!;
        public string VendorRma { get; set; } = null!;
        public string ItemDesc { get; set; } = null!;
        public string VendorItem { get; set; } = null!;
        public string VendorName { get; set; } = null!;
        public string PoNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public DateTime DateFailed { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateServiced { get; set; }
        public string RepairTime { get; set; } = null!;
        public string TechName { get; set; } = null!;
        public string Failure { get; set; } = null!;
        public string CorrectiveAction { get; set; } = null!;
        public string ItemNumber { get; set; } = null!;
    }
}
