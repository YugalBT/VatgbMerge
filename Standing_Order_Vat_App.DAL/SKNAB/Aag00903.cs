using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00903
    {
        public int AaBudgetId { get; set; }
        public string AaBudget { get; set; } = null!;
        public string AaBudgetDescr { get; set; } = null!;
        public int AaBudgetTreeId { get; set; }
        public short Year1 { get; set; }
        public string Budpwrd { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
