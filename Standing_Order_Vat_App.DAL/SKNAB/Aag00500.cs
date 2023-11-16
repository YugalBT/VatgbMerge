using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00500
    {
        public int AaDateId { get; set; }
        public DateTime Date1 { get; set; }
        public short AaCalWeek { get; set; }
        public short AaCalMonth { get; set; }
        public short AaCalQuarter { get; set; }
        public short AaCalHalfYear { get; set; }
        public short AaCalYear { get; set; }
        public short AaFiscalWeek { get; set; }
        public short AaFiscalPeriod { get; set; }
        public short AaFiscalQuarter { get; set; }
        public short AaFiscalHalfYear { get; set; }
        public short AaFiscalYear { get; set; }
        public int DexRowId { get; set; }
    }
}
