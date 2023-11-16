using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy01100
    {
        public short Series { get; set; }
        public int Seqnumbr { get; set; }
        public int Actindx { get; set; }
        public string Ptgacdsc { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
