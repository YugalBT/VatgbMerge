using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv30600
    {
        public short Ivdoctyp { get; set; }
        public string Docnumbr { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public int Sltsqnum { get; set; }
        public string Lotatrb1 { get; set; } = null!;
        public string Lotatrb2 { get; set; } = null!;
        public string Lotatrb3 { get; set; } = null!;
        public DateTime Lotatrb4 { get; set; }
        public DateTime Lotatrb5 { get; set; }
        public int DexRowId { get; set; }
    }
}
