using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Be021030
    {
        public string EmpidI { get; set; } = null!;
        public short Index1 { get; set; }
        public short IindexI { get; set; }
        public DateTime IdateI { get; set; }
        public decimal IbenefitamountI { get; set; }
        public byte Check1I { get; set; }
        public string Dscriptn { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
