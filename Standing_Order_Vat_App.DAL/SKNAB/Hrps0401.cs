using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrps0401
    {
        public string Pystptblid { get; set; } = null!;
        public DateTime EffectiveDate { get; set; }
        public short Step { get; set; }
        public short MonthsInStepStart { get; set; }
        public short MonthsInStepEnd { get; set; }
        public decimal Payrtamt { get; set; }
        public int DexRowId { get; set; }
    }
}
