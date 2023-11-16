using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag10000
    {
        public int AaGlworkHdrId { get; set; }
        public int Jrnentry { get; set; }
        public decimal Rctrxseq { get; set; }
        public DateTime Glpostdt { get; set; }
        public short AaTrxtype { get; set; }
        public byte[] AaHdrErrors { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
