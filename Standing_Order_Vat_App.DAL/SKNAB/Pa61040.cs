using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa61040
    {
        public string Paprojnumber { get; set; } = null!;
        public string Pabillcycleid1 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
