using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm20300
    {
        public decimal Cmrecnum { get; set; }
        public string SRecNum { get; set; } = null!;
        public short Cntrltyp { get; set; }
        public byte Deposited { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public string Chekbkid { get; set; } = null!;
        public string Depositnumber { get; set; } = null!;
        public string Rcptnmbr { get; set; } = null!;
        public DateTime Receiptdate { get; set; }
        public decimal Rcptamt { get; set; }
        public short RcpType { get; set; }
        public string Cardname { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public string Bankname { get; set; } = null!;
        public string Bnkbrnch { get; set; } = null!;
        public DateTime Glpostdt { get; set; }
        public DateTime Posteddt { get; set; }
        public string Ptdusrid { get; set; } = null!;
        public string CmlinkId { get; set; } = null!;
        public string RcvdFrom { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public byte Voided { get; set; }
        public DateTime Voiddate { get; set; }
        public DateTime Voidpdate { get; set; }
        public string Voiddesc { get; set; } = null!;
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public short Rcrdstts { get; set; }
        public string Sourcdoc { get; set; } = null!;
        public string Srcdocnum { get; set; } = null!;
        public short Srcdoctyp { get; set; }
        public string Audittrail { get; set; } = null!;
        public decimal Origamt { get; set; }
        public decimal CheckbookAmount { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Rcvgratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public decimal ReceivingExchangeRate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public short Rcvgrtclcmtd { get; set; }
        public DateTime Expndate { get; set; }
        public short Currnidx { get; set; }
        public short Decplcur { get; set; }
        public decimal Rlganlos { get; set; }
        public int CashAccountIndex { get; set; }
        public int RealizedGlAccountInde { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public decimal ReceivingDenomExrate { get; set; }
        public short ReceivingMcTransaction { get; set; }
        public int DexRowId { get; set; }
    }
}
