using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2ben34
    {
        public string EmpidI { get; set; } = null!;
        public short I1I { get; set; }
        public decimal IbenefitamountI { get; set; }
        public short I2I { get; set; }
        public byte Check1I { get; set; }
        public byte Check2I { get; set; }
        public int DexRowId { get; set; }
    }
}
