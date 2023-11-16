using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Af40104
    {
        public short Reportid { get; set; }
        public short Clcolnum { get; set; }
        public short Tknodnum { get; set; }
        public short Tkntype { get; set; }
        public short Tknvalue { get; set; }
        public decimal Tkndlval { get; set; }
        public string Tknunact1 { get; set; } = null!;
        public string Tknunact2 { get; set; } = null!;
        public string Tknunact3 { get; set; } = null!;
        public string Tknunact4 { get; set; } = null!;
        public string Tknunact5 { get; set; } = null!;
        public string Tknunact6 { get; set; } = null!;
        public string Tknunact7 { get; set; } = null!;
        public string Tknunact8 { get; set; } = null!;
        public string Tknunact9 { get; set; } = null!;
        public string Tknunact10 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
