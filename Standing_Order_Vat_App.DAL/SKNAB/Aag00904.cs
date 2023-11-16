using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00904
    {
        public int AaBudgetId { get; set; }
        public int AaCodeSequence { get; set; }
        public short AaFiscalPeriod { get; set; }
        public int AaActualPriliminary { get; set; }
        public decimal Balance { get; set; }
        public decimal Quantity { get; set; }
        public int DexRowId { get; set; }
    }
}
