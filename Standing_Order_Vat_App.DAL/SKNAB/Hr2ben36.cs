using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2ben36
    {
        public short I1I { get; set; }
        public string CompletenameI { get; set; } = null!;
        public string Benefit { get; set; } = null!;
        public decimal IbenefitamountI { get; set; }
        public decimal MultipleI { get; set; }
        public short I2I { get; set; }
        public short GbI { get; set; }
        public byte Check1I { get; set; }
        public byte Check2I { get; set; }
        public int DexRowId { get; set; }
    }
}
