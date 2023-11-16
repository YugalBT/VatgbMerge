using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop40400
    {
        public short Index1 { get; set; }
        public string Ustabval { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
