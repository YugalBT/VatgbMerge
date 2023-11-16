using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class EmpRep
    {
        public int Day { get; set; }
        public string? Jan { get; set; }
        public string? Feb { get; set; }
        public string? Mar { get; set; }
        public string? Apr { get; set; }
        public string? May { get; set; }
        public string? Jun { get; set; }
        public string? Jul { get; set; }
        public string? Aug { get; set; }
        public string? Sep { get; set; }
        public string? Oct { get; set; }
        public string? Nov { get; set; }
        public string? Dec { get; set; }
        public int? EmpId { get; set; }
        public int? TheYear { get; set; }
    }
}
