using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pdk10503
    {
        public string PdkEeNo { get; set; } = null!;
        public byte TaxRecalculated { get; set; }
        public int DexRowId { get; set; }
    }
}
