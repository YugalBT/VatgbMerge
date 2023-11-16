using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00905
    {
        public int AaBudgetId { get; set; }
        public int AaCodeSequence { get; set; }
        public int Actindx { get; set; }
        public short AaFiscalPeriod { get; set; }
        public int AaActualPriliminary { get; set; }
        public short AaRange { get; set; }
        public decimal Balance { get; set; }
        public int DexRowId { get; set; }
    }
}
