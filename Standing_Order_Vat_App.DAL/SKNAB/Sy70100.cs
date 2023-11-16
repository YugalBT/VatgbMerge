using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy70100
    {
        public short Rptgrind { get; set; }
        public decimal Rtgrsbin { get; set; }
        public short Rtpachin { get; set; }
        public short Grpsbind { get; set; }
        public short Rptindx1 { get; set; }
        public short Rptindx2 { get; set; }
        public short Rtcfgwin { get; set; }
        public decimal Rptindx3 { get; set; }
        public int DexRowId { get; set; }
    }
}
