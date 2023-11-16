using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv30400
    {
        public string Trxsorce { get; set; } = null!;
        public short Ivdoctyp { get; set; }
        public string Docnumbr { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public int Sltsqnum { get; set; }
        public string Serltnum { get; set; } = null!;
        public decimal Serltqty { get; set; }
        public string Frombin { get; set; } = null!;
        public string Tobin { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public int DexRowId { get; set; }
    }
}
