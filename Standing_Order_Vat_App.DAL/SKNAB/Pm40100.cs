using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm40100
    {
        public string Uniqkey { get; set; } = null!;
        public short Adupinnm { get; set; }
        public byte Ovvchnum { get; set; }
        public byte Trkdisav { get; set; }
        public byte Prthatrb { get; set; }
        public short Ageby { get; set; }
        public short Applyby { get; set; }
        public string Rmvndhpw { get; set; } = null!;
        public string Rmvtrhpw { get; set; } = null!;
        public string Xcdminpw { get; set; } = null!;
        public string Wrofpswd { get; set; } = null!;
        public string Ntvchnum { get; set; } = null!;
        public string Pmnpynbr { get; set; } = null!;
        public string Nxtvndid { get; set; } = null!;
        public string Usrdfpr1 { get; set; } = null!;
        public string Usrdrpr2 { get; set; } = null!;
        public string Pmtrxdsc1 { get; set; } = null!;
        public string Pmtrxdsc2 { get; set; } = null!;
        public string Pmtrxdsc3 { get; set; } = null!;
        public string Pmtrxdsc4 { get; set; } = null!;
        public string Pmtrxdsc5 { get; set; } = null!;
        public string Pmtrxdsc6 { get; set; } = null!;
        public string Pmtrxdsc7 { get; set; } = null!;
        public string Pmtrxdsc8 { get; set; } = null!;
        public string Pmtrxabr1 { get; set; } = null!;
        public string Pmtrxabr2 { get; set; } = null!;
        public string Pmtrxabr3 { get; set; } = null!;
        public string Pmtrxabr4 { get; set; } = null!;
        public string Pmtrxabr5 { get; set; } = null!;
        public string Pmtrxabr6 { get; set; } = null!;
        public string Pmtrxabr7 { get; set; } = null!;
        public string Pmtrxabr8 { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public string Pchschid { get; set; } = null!;
        public string Frtschid { get; set; } = null!;
        public string Mscschid { get; set; } = null!;
        public DateTime Lstyecal { get; set; }
        public DateTime Lstyefsc { get; set; }
        public short CheckFormatDefault { get; set; }
        public short CheckStubDefault { get; set; }
        public byte Prntprvslyapplddcs { get; set; }
        public byte DelUpdoc { get; set; }
        public byte PrntTaxDetDoc { get; set; }
        public short DateSensitivitySumView { get; set; }
        public byte Prntdcur { get; set; }
        public byte Ageunappldcr { get; set; }
        public string Pmnxtschdnbr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
