using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv00106
    {
        public string Itemnmbr { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public decimal Qtybsuom { get; set; }
        public short Umpuropt { get; set; }
        public int DexRowId { get; set; }
    }
}
