using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv30101
    {
        public string Itemnmbr { get; set; } = null!;
        public decimal Sqtysytd { get; set; }
        public decimal Sumcsytd { get; set; }
        public decimal Smslsytd { get; set; }
        public decimal Sqtyslyr { get; set; }
        public decimal Sumcslyr { get; set; }
        public decimal Smslslyr { get; set; }
        public int DexRowId { get; set; }
    }
}
