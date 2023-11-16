using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.GB_Register
{
    public partial class VwEmp
    {
        public int RecordId { get; set; }
        public DateTime DateRequested { get; set; }
        public string? InitName { get; set; }
        public DateTime? DatePerformed { get; set; }
    }
}
