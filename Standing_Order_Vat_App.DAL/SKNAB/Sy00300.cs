using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy00300
    {
        public short Sgmtnumb { get; set; }
        public string Sgmtname { get; set; } = null!;
        public short Lofsgmnt { get; set; }
        public short Mxlenseg { get; set; }
        public short Usdfsgky { get; set; }
        public byte Mnsegind { get; set; }
        public string SegmentWidth { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
