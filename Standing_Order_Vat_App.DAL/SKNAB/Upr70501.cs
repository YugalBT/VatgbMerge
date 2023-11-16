using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr70501
    {
        public short Rptgrind { get; set; }
        public short Rtpachin { get; set; }
        public decimal Rtgrsbin { get; set; }
        public short Cmpanyid { get; set; }
        public int DexRowId { get; set; }
    }
}
