using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr24be15
    {
        public string EmpidI { get; set; } = null!;
        public string Benefit { get; set; } = null!;
        public short I1I { get; set; }
        public short IbenefitpercentI { get; set; }
        public decimal IbenefitamountI { get; set; }
        public int DexRowId { get; set; }
    }
}
