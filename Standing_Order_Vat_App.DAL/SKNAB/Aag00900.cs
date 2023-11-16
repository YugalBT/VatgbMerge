using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00900
    {
        public int AaBudgetTreeId { get; set; }
        public string AaBudgetTree { get; set; } = null!;
        public string AaBudgetTreeDescr { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
