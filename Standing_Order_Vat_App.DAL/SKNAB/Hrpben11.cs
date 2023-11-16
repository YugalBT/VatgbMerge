using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrpben11
    {
        public string CopaycodeI { get; set; } = null!;
        public string Benefit { get; set; } = null!;
        public decimal CopayamountI { get; set; }
        public int DexRowId { get; set; }
    }
}
