using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VwActAb
    {
        public int IdEmployee { get; set; }
        public int? NmSpecialDays { get; set; }
        public DateTime? DtStart { get; set; }
        public DateTime? DtEnd { get; set; }
        public DateTime? DtInformed { get; set; }
        public string? TxReasons { get; set; }
        public DateTime? DtMod { get; set; }
        public bool? InTdAm { get; set; }
        public bool? InTdPm { get; set; }
        public DateTime? TmInformed { get; set; }
        public string? TxInformedBy { get; set; }
    }
}
