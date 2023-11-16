using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv10401
    {
        public string Prcshid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Epitmtyp { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public byte Brkptprc { get; set; }
        public byte Active { get; set; }
        public string Baseuofm { get; set; } = null!;
        public string Prodtcod { get; set; } = null!;
        public short Promotyp { get; set; }
        public short Promolvl { get; set; }
        public int DexRowId { get; set; }
    }
}
