using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cam30100
    {
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public int CamControlAccountIndex { get; set; }
        public string CamAccountNumString { get; set; } = null!;
        public string CamControlAcctDescr { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public int Actindx { get; set; }
        public string Actnumst { get; set; } = null!;
        public string Actdescr { get; set; } = null!;
        public string Vchrnmbr { get; set; } = null!;
        public string Aptvchnm { get; set; } = null!;
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal CamAmountTotal { get; set; }
        public int DexRowId { get; set; }
    }
}
