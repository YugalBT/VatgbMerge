using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag30000
    {
        public int AaGlhdrId { get; set; }
        public int Jrnentry { get; set; }
        public decimal Rctrxseq { get; set; }
        public short Year1 { get; set; }
        public short AaTrxtype { get; set; }
        public string AaGltrxsource { get; set; } = null!;
        public string AaTrxsource { get; set; } = null!;
        public DateTime Glpostdt { get; set; }
        public int DexRowId { get; set; }
    }
}
