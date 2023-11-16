using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrpsy01
    {
        public short Index1 { get; set; }
        public string Filename { get; set; } = null!;
        public string Errmsg1I { get; set; } = null!;
        public string Errmsg2I { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
