using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa14100
    {
        public short PatranType { get; set; }
        public string Padocnumber20 { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Pachgordno { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
