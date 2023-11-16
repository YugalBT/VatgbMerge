using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy01000
    {
        public byte Reprntnt { get; set; }
        public short Series { get; set; }
        public int Seqnumbr { get; set; }
        public string Trxsourc { get; set; } = null!;
        public string Trxsrcpx { get; set; } = null!;
        public int Ntrxsnum { get; set; }
        public string Sourcdoc { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
