using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl40101
    {
        public string Bsnsfmid { get; set; } = null!;
        public decimal Sequence1 { get; set; }
        public int Actindx { get; set; }
        public int DexRowId { get; set; }
    }
}
