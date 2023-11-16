using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr41100
    {
        public string Statecd { get; set; } = null!;
        public string Statenam { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
