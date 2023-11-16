using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class AaActualBudgetInquiryView
    {
        public int Year1 { get; set; }
        public int? AaFiscalPeriod { get; set; }
        public decimal? Perdblnc { get; set; }
        public decimal ActualAmount { get; set; }
        public string? AaLvlCodeString { get; set; }
        public int DexRowId { get; set; }
    }
}
