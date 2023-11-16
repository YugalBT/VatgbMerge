using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class Savdrm
    {
        public int AccountNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public DateTime? DateOpened { get; set; }
        public DateTime? DormantDate { get; set; }
        public DateTime? InactiveDate { get; set; }
        public double? Balance { get; set; }
        public double? InterestAccrued { get; set; }
        public double? InterestLastPaid { get; set; }
        public DateTime? DateIntrestLastPaid { get; set; }
        public double? AccrInt1stMonth { get; set; }
        public double? AccrInt2ndMonth { get; set; }
        public DateTime? DateReActivated { get; set; }
        public string? ReactivateOp { get; set; }
    }
}
