using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm40101
    {
        public string Uniqkey { get; set; } = null!;
        public short Index1 { get; set; }
        public string Dscriptn { get; set; } = null!;
        public short Endgpdys { get; set; }
        public int DexRowId { get; set; }
    }
}
