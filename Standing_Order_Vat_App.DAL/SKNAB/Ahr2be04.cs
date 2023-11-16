using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ahr2be04
    {
        public string EmpidI { get; set; } = null!;
        public string Benefit { get; set; } = null!;
        public byte Check1I { get; set; }
        public DateTime DatedueI { get; set; }
        public string Commentstr10I { get; set; } = null!;
        public byte Check3I { get; set; }
        public byte Check4I { get; set; }
        public byte Check5I { get; set; }
        public string Dscriptn { get; set; } = null!;
        public decimal BenefitcostI { get; set; }
        public decimal Benefitcost2I { get; set; }
        public decimal IbenefitamountI { get; set; }
        public int DexRowId { get; set; }
    }
}
