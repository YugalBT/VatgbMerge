using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2ben39
    {
        public string EmpidI { get; set; } = null!;
        public DateTime Bnfbegdt { get; set; }
        public string Benefit { get; set; } = null!;
        public short I2I { get; set; }
        public short I1I { get; set; }
        public string BenefitfundcodeI { get; set; } = null!;
        public string BenefitfundnameI { get; set; } = null!;
        public byte Check1I { get; set; }
        public short IbenefitpercentI { get; set; }
        public decimal IbenefitamountI { get; set; }
        public int DexRowId { get; set; }
    }
}
