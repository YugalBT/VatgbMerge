using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag2001t
    {
        public decimal Cmrecnum { get; set; }
        public string Depositnumber { get; set; } = null!;
        public short RcpType { get; set; }
        public string Rcptnmbr { get; set; } = null!;
        public decimal Rcptamt { get; set; }
        public string Bankname { get; set; } = null!;
        public string Bnkbrnch { get; set; } = null!;
        public byte Updated { get; set; }
        public byte Marked { get; set; }
        public DateTime Receiptdate { get; set; }
        public decimal CheckbookAmount { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public decimal ReceivingExchangeRate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public DateTime Expndate { get; set; }
        public decimal Rlganlos { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public short Decplcur { get; set; }
        public decimal Origamt { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public int DexRowId { get; set; }
    }
}
