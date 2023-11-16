using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl00102
    {
        public short Accatnum { get; set; }
        public string Accatdsc { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
