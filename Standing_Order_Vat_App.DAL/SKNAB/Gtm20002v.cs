using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gtm20002v
    {
        public string AaTrxDim { get; set; } = null!;
        public string AaTrxDimCode { get; set; } = null!;
        public int AaBudgetId { get; set; }
        public string AaBudget { get; set; } = null!;
        public short Year1 { get; set; }
        public short AaFiscalPeriod { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public decimal Balance { get; set; }
        public int DexRowId { get; set; }
    }
}
