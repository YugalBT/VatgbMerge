using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2ben11
    {
        public string Benefit { get; set; } = null!;
        public short I1I { get; set; }
        public string BenefitfundcodeI { get; set; } = null!;
        public string BenefitfundnameI { get; set; } = null!;
        public byte Check1I { get; set; }
        public int DexRowId { get; set; }
    }
}
