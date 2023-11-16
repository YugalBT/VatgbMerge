using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cam40002
    {
        public short CamSeries { get; set; }
        public string Sgmntid { get; set; } = null!;
        public int CamControlAccountIndex { get; set; }
        public int CamAccrualAccountIndex { get; set; }
        public string CamControlAcctDescr { get; set; } = null!;
        public string CamAccrualAcctDescr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
