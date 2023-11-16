using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag20001
    {
        public int AaSubLedgerHdrId { get; set; }
        public int AaSubLedgerDistId { get; set; }
        public string Interid { get; set; } = null!;
        public string CorrespondingUnit { get; set; } = null!;
        public int Actindx { get; set; }
        public short Disttype { get; set; }
        public short Accttype { get; set; }
        public short AaBrowseType { get; set; }
        public short Decplacs { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public int Seqnumbr { get; set; }
        public DateTime Glpostdt { get; set; }
        public int AaCustId { get; set; }
        public int AaVendId { get; set; }
        public int AaSiteId { get; set; }
        public int AaItemId { get; set; }
        public short AaCopyStatus { get; set; }
        public byte AaWinWasOpen { get; set; }
        public byte Posted { get; set; }
        public byte History { get; set; }
        public byte[] AaDistErrors { get; set; } = null!;
        public string Aptvchnm { get; set; } = null!;
        public short Aptodcty { get; set; }
        public int AaFutureDist { get; set; }
        public byte AaOffsetAcct { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Trxloctn { get; set; } = null!;
        public string Binnmbr { get; set; } = null!;
        public string Trnstloc { get; set; } = null!;
        public decimal Trxqty { get; set; }
        public DateTime AaChangeDate { get; set; }
        public DateTime AaChangeTime { get; set; }
        public int DexRowId { get; set; }
    }
}
