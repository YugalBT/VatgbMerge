using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00905
    {
        public string Techstat { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public byte TechAvailable { get; set; }
        public int DexRowId { get; set; }
    }
}
