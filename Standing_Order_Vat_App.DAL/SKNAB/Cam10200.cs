using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cam10200
    {
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public short Cmpanyid { get; set; }
        public short CamSeries { get; set; }
        public short Sgmtnumb { get; set; }
        public string Userid { get; set; } = null!;
        public decimal CamAmountTotal { get; set; }
        public short CamCntrlCount1 { get; set; }
        public short CamCntrlCount2 { get; set; }
        public short CamDistCount1 { get; set; }
        public short CamDistCount2 { get; set; }
        public short CamDistCount3 { get; set; }
        public short CamDistCount4 { get; set; }
        public short CamDistCount5 { get; set; }
        public short CamDistCount6 { get; set; }
        public short CamDistCount7 { get; set; }
        public short CamDistCount8 { get; set; }
        public short CamDistCount9 { get; set; }
        public short CamDistCount10 { get; set; }
        public short CamDistCount11 { get; set; }
        public short CamDistCount12 { get; set; }
        public short CamDistCount13 { get; set; }
        public short CamDistCount14 { get; set; }
        public short CamDistCount15 { get; set; }
        public short CamDistCount16 { get; set; }
        public short CamDocCount1 { get; set; }
        public short CamDocCount2 { get; set; }
        public short CamDocCount3 { get; set; }
        public short CamDocCount4 { get; set; }
        public short CamDocCount5 { get; set; }
        public short CamDocCount6 { get; set; }
        public string Bachnumb { get; set; } = null!;
        public string Bchcomnt { get; set; } = null!;
        public string Refrence { get; set; } = null!;
        public string Sourcdoc { get; set; } = null!;
        public string Trxsrcpx { get; set; } = null!;
        public DateTime Trxdate { get; set; }
        public DateTime Rvrsngdt { get; set; }
        public short CamStatus { get; set; }
        public int DexRowId { get; set; }
    }
}
