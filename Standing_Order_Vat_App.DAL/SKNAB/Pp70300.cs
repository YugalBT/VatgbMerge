using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pp70300
    {
        public decimal Rtgrsbin { get; set; }
        public short Rtpachin { get; set; }
        public short Rptgrind { get; set; }
        public string Rptgrnms { get; set; } = null!;
        public short Rtcfgwin { get; set; }
        public int DexRowId { get; set; }
    }
}
