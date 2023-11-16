using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm00100
    {
        public string Chekbkid { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Bankid { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public int Actindx { get; set; }
        public string Bnkactnm { get; set; } = null!;
        public string Nxtchnum { get; set; } = null!;
        public string NextDepositNumber { get; set; } = null!;
        public byte Inactive { get; set; }
        public short Dydepclr { get; set; }
        public string Xcdmchpw { get; set; } = null!;
        public decimal Mxchdlr { get; set; }
        public byte Dupchnum { get; set; }
        public byte Ovchnum1 { get; set; }
        public string Locatnid { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Cmusrdf1 { get; set; } = null!;
        public string Cmusrdf2 { get; set; } = null!;
        public DateTime LastReconciledDate { get; set; }
        public decimal LastReconciledBalance { get; set; }
        public decimal Currblnc { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public byte Recond { get; set; }
        public decimal ReconcileInProgress { get; set; }
        public string DepositInProgress { get; set; } = null!;
        public string Chbkpswd { get; set; } = null!;
        public string Curncypd { get; set; } = null!;
        public string Crncyrcd { get; set; } = null!;
        public decimal Adpvadlr { get; set; }
        public string Adpvapwd { get; set; } = null!;
        public short Dychtclr { get; set; }
        public short Cmpanyid { get; set; }
        public short Chkbktyp { get; set; }
        public string Ddactnum { get; set; } = null!;
        public string Ddindnam { get; set; } = null!;
        public string Ddtrans { get; set; } = null!;
        public string PaymentRateTypeId { get; set; } = null!;
        public string DepositRateTypeId { get; set; } = null!;
        public int CashInTransAcctIdx { get; set; }
        public int DexRowId { get; set; }
    }
}
