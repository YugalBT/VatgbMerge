using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class Atmaudit
    {
        public string? Description { get; set; }
        public int? Number { get; set; }
        public long? Amount { get; set; }
        public DateTime? AuditDate { get; set; }
        public string? Machine { get; set; }
        public int? AtmNumber { get; set; }
    }
}
