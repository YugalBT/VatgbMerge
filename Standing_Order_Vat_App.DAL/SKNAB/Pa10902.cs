using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa10902
    {
        public string PaivDocumentNo { get; set; } = null!;
        public short PaivTransferType { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Serltnum { get; set; } = null!;
        public decimal Serltqty { get; set; }
        public int Lnitmseq { get; set; }
        public int Sltsqnum { get; set; }
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public short Ovrserlt { get; set; }
        public string Trxsorce { get; set; } = null!;
        public string Frombin { get; set; } = null!;
        public string Tobin { get; set; } = null!;
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public decimal Qtyscrapped { get; set; }
        public int DexRowId { get; set; }
    }
}
