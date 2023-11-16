using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Dd10200
    {
        public short Index1 { get; set; }
        public string Ddline { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
