using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa03400
    {
        public string Userid { get; set; } = null!;
        public short Index1 { get; set; }
        public string Filename { get; set; } = null!;
        public string Ermsgtxt { get; set; } = null!;
        public string Ermsgtx2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
