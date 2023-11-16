using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa00905
    {
        public string Glintbtchnum { get; set; } = null!;
        public DateTime Glinttrxdate { get; set; }
        public int Actindx { get; set; }
        public int Assetindex { get; set; }
        public short Fayear { get; set; }
        public short Faperiod { get; set; }
        public string Sourcdoc { get; set; } = null!;
        public decimal Amount { get; set; }
        public int DexRowId { get; set; }
    }
}
