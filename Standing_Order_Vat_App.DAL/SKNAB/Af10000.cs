using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Af10000
    {
        public decimal Sequence1 { get; set; }
        public string Pperadsc { get; set; } = null!;
        public decimal Pperadam { get; set; }
        public int DexRowId { get; set; }
    }
}
