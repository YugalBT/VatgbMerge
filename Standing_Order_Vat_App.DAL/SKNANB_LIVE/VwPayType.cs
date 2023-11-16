using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VwPayType
    {
        public int PaymentId { get; set; }
        public int EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public string? TypeName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? IdSocialSec { get; set; }
        public DateTime DtBegin { get; set; }
        public DateTime DtEnd { get; set; }
        public DateTime DtPaid { get; set; }
    }
}
