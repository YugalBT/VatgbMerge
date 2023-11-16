using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class AagMlbudgetViewQuantity
    {
        public int Reptype { get; set; }
        public int AaBudgetId { get; set; }
        public string AaBudget { get; set; } = null!;
        public string AaBudgetDescr { get; set; } = null!;
        public short Year1 { get; set; }
        public int AaCodeSequence { get; set; }
        public string AaLvlCodeString { get; set; } = null!;
        public short AaFiscalPeriod { get; set; }
        public decimal Balance { get; set; }
        public int AaBudgetTreeId { get; set; }
    }
}
