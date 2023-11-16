using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class View3
    {
        public DateTime? DtStart { get; set; }
        public DateTime? DtEnd { get; set; }
        public bool? InTdAm { get; set; }
        public bool? InTdPm { get; set; }
        public string? TxReasons { get; set; }
        public double? TotalDays { get; set; }
    }
}
