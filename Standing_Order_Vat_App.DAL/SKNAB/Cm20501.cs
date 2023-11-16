using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm20501
    {
        public string Chekbkid { get; set; } = null!;
        public decimal Cmrecnum { get; set; }
        public decimal Reconum { get; set; }
        public int Dstsqnum { get; set; }
        public int Dstindx { get; set; }
        public DateTime Trxdate { get; set; }
        public short CmtrxType { get; set; }
        public decimal Trxamnt { get; set; }
        public byte Posted { get; set; }
        public string DistRef { get; set; } = null!;
        public string CmtrxNum { get; set; } = null!;
        public DateTime Glpostdt { get; set; }
        public decimal Noteindx { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public DateTime Expndate { get; set; }
        public short Decplcur { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public int DexRowId { get; set; }
    }
}
