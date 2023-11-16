using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv30702
    {
        public string Stckcntid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Binnmbr { get; set; } = null!;
        public int Sltsqnum { get; set; }
        public decimal Countedqty { get; set; }
        public decimal Capturedqty { get; set; }
        public short Itmtrkop { get; set; }
        public string Ivdocnbr { get; set; } = null!;
        public short Ivdoctyp { get; set; }
        public string Serltnum { get; set; } = null!;
        public decimal Varianceqty { get; set; }
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public int DexRowId { get; set; }
    }
}
