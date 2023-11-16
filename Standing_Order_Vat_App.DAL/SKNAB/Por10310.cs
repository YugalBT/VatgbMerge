using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Por10310
    {
        public string Poprctnm { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public int Invindx { get; set; }
        public decimal Ivextcst { get; set; }
        public decimal Ivoetcst { get; set; }
        public int Offindx { get; set; }
        public decimal Ivosexct { get; set; }
        public decimal Ivosoect { get; set; }
        public int VarianceIndex { get; set; }
        public decimal Ivvexcst { get; set; }
        public decimal Ivvoecst { get; set; }
        public int DexRowId { get; set; }
    }
}
