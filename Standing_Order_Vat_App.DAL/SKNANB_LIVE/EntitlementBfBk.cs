using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class EntitlementBfBk
    {
        public int KeyId { get; set; }
        public int? EmployeeId { get; set; }
        public string? AbsentType { get; set; }
        public int? Year { get; set; }
        public double? Value { get; set; }
        public string? User { get; set; }
        public DateTime? Date { get; set; }
    }
}
