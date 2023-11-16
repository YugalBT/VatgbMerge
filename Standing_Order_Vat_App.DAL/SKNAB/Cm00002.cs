using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm00002
    {
        public decimal Cmrecnum { get; set; }
        public decimal Reconum { get; set; }
        public string CmtrxNum { get; set; } = null!;
        public short CmtrxType { get; set; }
        public string CmlinkId { get; set; } = null!;
        public DateTime Trxdate { get; set; }
        public decimal Trxamnt { get; set; }
        public DateTime Clearedate { get; set; }
        public decimal ClrdAmt { get; set; }
        public string Curncyid { get; set; } = null!;
        public string Paidtorcvdfrom { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public short Deptype { get; set; }
        public string Sourcdoc { get; set; } = null!;
        public short Srcdoctyp { get; set; }
        public string Srcdocnum { get; set; } = null!;
        public byte Updated { get; set; }
        public byte Reconflg { get; set; }
        public byte Chgflag { get; set; }
        public byte Marked { get; set; }
        public string Userid { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
