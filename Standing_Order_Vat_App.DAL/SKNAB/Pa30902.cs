using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa30902
    {
        public string Trxsorce { get; set; } = null!;
        public short PaivTransferType { get; set; }
        public string PaivDocumentNo { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public int Sltsqnum { get; set; }
        public string Serltnum { get; set; } = null!;
        public decimal Serltqty { get; set; }
        public string Frombin { get; set; } = null!;
        public string Tobin { get; set; } = null!;
        public decimal Pabillqty { get; set; }
        public byte Pabilled { get; set; }
        public byte Pabilledagn { get; set; }
        public decimal Qtyscrapped { get; set; }
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public int DexRowId { get; set; }
    }
}
