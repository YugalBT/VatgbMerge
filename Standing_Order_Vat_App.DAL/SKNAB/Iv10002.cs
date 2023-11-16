using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv10002
    {
        public string Ivdocnbr { get; set; } = null!;
        public short Ivdoctyp { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Serltnum { get; set; } = null!;
        public decimal Serltqty { get; set; }
        public decimal Lnseqnbr { get; set; }
        public int Sltsqnum { get; set; }
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public short Ovrserlt { get; set; }
        public decimal Qtyscrapped { get; set; }
        public string Frombin { get; set; } = null!;
        public string Tobin { get; set; } = null!;
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public int DexRowId { get; set; }
    }
}
