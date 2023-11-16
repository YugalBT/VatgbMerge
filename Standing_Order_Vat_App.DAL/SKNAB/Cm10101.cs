using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm10101
    {
        public string Depositnumber { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public decimal Cmrecnum { get; set; }
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public DateTime Expndate { get; set; }
        public short Decplcur { get; set; }
        public short Rcptcount { get; set; }
        public decimal Orchkttl { get; set; }
        public short OriginatingCheckCount { get; set; }
        public decimal OrigCreditCardTotal { get; set; }
        public short OriginatingCreditCard { get; set; }
        public decimal OriginatingCashTotal { get; set; }
        public short OriginatingCashCount { get; set; }
        public decimal OriginatingCoinAmount { get; set; }
        public decimal OriginatingDepositAmou { get; set; }
        public decimal OriginatingCheckbookAm { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public int DexRowId { get; set; }
    }
}
