using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ahr2be31
    {
        public string EmpidI { get; set; } = null!;
        public byte Check1I { get; set; }
        public byte Check2I { get; set; }
        public DateTime IdateI { get; set; }
        public string Commentstr10I { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
