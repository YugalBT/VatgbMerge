using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ahr2sa02
    {
        public string EmpidI { get; set; } = null!;
        public short IsequencenumberI { get; set; }
        public DateTime EffectivedateI { get; set; }
        public string Dscriptn { get; set; } = null!;
        public decimal WageI { get; set; }
        public int DexRowId { get; set; }
    }
}
