using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cam10210
    {
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public short Cmpanyid { get; set; }
        public string Sgmntid { get; set; } = null!;
        public int CamControlAccountIndex { get; set; }
        public string CamcontrolAccount1 { get; set; } = null!;
        public string CamcontrolAccount2 { get; set; } = null!;
        public string CamcontrolAccount3 { get; set; } = null!;
        public string CamcontrolAccount4 { get; set; } = null!;
        public string CamcontrolAccount5 { get; set; } = null!;
        public string CamcontrolAccount6 { get; set; } = null!;
        public string CamcontrolAccount7 { get; set; } = null!;
        public string CamcontrolAccount8 { get; set; } = null!;
        public string CamcontrolAccount9 { get; set; } = null!;
        public string CamcontrolAccount10 { get; set; } = null!;
        public string CamControlAcctDescr { get; set; } = null!;
        public decimal CamAmountTotal { get; set; }
        public int DexRowId { get; set; }
    }
}
