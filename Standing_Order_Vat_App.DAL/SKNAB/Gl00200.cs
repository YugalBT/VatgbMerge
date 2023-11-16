using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl00200
    {
        public string Budgetid { get; set; } = null!;
        public string Budcomnt { get; set; } = null!;
        public string Budpwrd { get; set; } = null!;
        public short Year1 { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
