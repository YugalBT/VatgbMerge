using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd028
    {
        public short Remtype { get; set; }
        public string Remitid { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Rgeavail { get; set; } = null!;
        public string Rnge { get; set; } = null!;
        public short Carry { get; set; }
        public byte Setted { get; set; }
        public short Settedby { get; set; }
        public int Fieldtype { get; set; }
        public decimal Lowcur { get; set; }
        public decimal Highcur { get; set; }
        public DateTime Lowdate { get; set; }
        public DateTime Highdate { get; set; }
        public string Lowstr { get; set; } = null!;
        public string Highstr { get; set; } = null!;
        public string Valbact1 { get; set; } = null!;
        public string Valbact2 { get; set; } = null!;
        public short Stadttok { get; set; }
        public short Enddttok { get; set; }
        public int DexRowId { get; set; }
    }
}
