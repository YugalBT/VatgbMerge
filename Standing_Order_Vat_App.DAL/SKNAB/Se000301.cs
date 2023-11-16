using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Se000301
    {
        public string Seoptnme { get; set; } = null!;
        public short Sgmtnumb { get; set; }
        public string Segment { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
