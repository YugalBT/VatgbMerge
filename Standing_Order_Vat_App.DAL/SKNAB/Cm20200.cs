using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm20200
    {
        public decimal Cmrecnum { get; set; }
        public string SRecNum { get; set; } = null!;
        public short Rcrdstts { get; set; }
        public string Chekbkid { get; set; } = null!;
        public string CmtrxNum { get; set; } = null!;
        public short CmtrxType { get; set; }
        public DateTime Trxdate { get; set; }
        public DateTime Glpostdt { get; set; }
        public decimal Trxamnt { get; set; }
        public string Curncyid { get; set; } = null!;
        public string CmlinkId { get; set; } = null!;
        public string Paidtorcvdfrom { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public byte Recond { get; set; }
        public decimal Reconum { get; set; }
        public decimal ClrdAmt { get; set; }
        public DateTime Clearedate { get; set; }
        public byte Voided { get; set; }
        public DateTime Voiddate { get; set; }
        public DateTime Voidpdate { get; set; }
        public string Voiddesc { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Audittrail { get; set; } = null!;
        public short Deptype { get; set; }
        public string Sourcdoc { get; set; } = null!;
        public short Srcdoctyp { get; set; }
        public string Srcdocnum { get; set; } = null!;
        public DateTime Posteddt { get; set; }
        public string Ptdusrid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public decimal Origamt { get; set; }
        public decimal CheckbookAmount { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public DateTime Expndate { get; set; }
        public short Currnidx { get; set; }
        public short Decplcur { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public decimal XfrRecordNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
