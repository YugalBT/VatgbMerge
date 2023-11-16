using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv40500
    {
        public string Lottype { get; set; } = null!;
        public string Ltatrdsc1 { get; set; } = null!;
        public string Ltatrdsc2 { get; set; } = null!;
        public string Ltatrdsc3 { get; set; } = null!;
        public string Ltatrdsc4 { get; set; } = null!;
        public string Ltatrdsc5 { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
