using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2ben14
    {
        public short IindexI { get; set; }
        public string BenefittypeI { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
