using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa02010
    {
        public string Pabillcycleid1 { get; set; } = null!;
        public string Pabillcycledesc1 { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
