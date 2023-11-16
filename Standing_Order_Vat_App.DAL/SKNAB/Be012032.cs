using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Be012032
    {
        public string CopaycodeI { get; set; } = null!;
        public string CopaydescriptionI { get; set; } = null!;
        public decimal CopayamountI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public int DexRowId { get; set; }
    }
}
