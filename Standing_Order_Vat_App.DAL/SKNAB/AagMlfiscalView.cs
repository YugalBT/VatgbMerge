using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class AagMlfiscalView
    {
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
