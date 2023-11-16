using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy70200
    {
        public short Rtpachin { get; set; }
        public short Rptgrind { get; set; }
        public decimal Rtgrsbin { get; set; }
        public string Rptgrnms { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
