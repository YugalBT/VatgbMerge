using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01162
    {
        public string Pacontnumber { get; set; } = null!;
        public decimal PaAgingPeriodWipAmt1 { get; set; }
        public decimal PaAgingPeriodWipAmt2 { get; set; }
        public decimal PaAgingPeriodWipAmt3 { get; set; }
        public decimal PaAgingPeriodWipAmt4 { get; set; }
        public decimal PaAgingPeriodWipAmt5 { get; set; }
        public decimal PaAgingPeriodWipAmt6 { get; set; }
        public decimal PaAgingPeriodWipAmt7 { get; set; }
        public decimal Patotcst { get; set; }
        public DateTime Lastaged { get; set; }
        public int DexRowId { get; set; }
    }
}
