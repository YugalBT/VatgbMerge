using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrpben12
    {
        public string EmpidI { get; set; } = null!;
        public string Benefit { get; set; } = null!;
        public string CopaycodeI { get; set; } = null!;
        public decimal CopayamountI { get; set; }
        public int DexRowId { get; set; }
    }
}
