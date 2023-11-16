using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class AagMlbudgetNodeBalance
    {
        public int AaBudgetId { get; set; }
        public string AaBudget { get; set; } = null!;
        public string AaBudgetDescr { get; set; } = null!;
        public int AaBudgetTreeId { get; set; }
        public short Year1 { get; set; }
        public decimal Balance { get; set; }
        public decimal Quantity { get; set; }
        public int AaTrxDimId { get; set; }
        public int AaOrder { get; set; }
        public int AaTrxDimCodeId { get; set; }
        public string AaTrxDimCode { get; set; } = null!;
        public string AaTrxDimCodeDescr { get; set; } = null!;
        public int AaCodeSequence { get; set; }
        public int AaLevel { get; set; }
        public string AaLvlCodeString { get; set; } = null!;
        public short AaCalMonth { get; set; }
        public short AaCalQuarter { get; set; }
        public short AaCalHalfYear { get; set; }
        public short AaCalYear { get; set; }
        public short AaFiscalPeriod { get; set; }
        public short AaFiscalQuarter { get; set; }
        public short AaFiscalHalfYear { get; set; }
        public short AaFiscalYear { get; set; }
    }
}
