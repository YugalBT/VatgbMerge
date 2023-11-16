using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2ben12
    {
        public string Benefit { get; set; } = null!;
        public short IindexI { get; set; }
        public decimal CostemployeeI { get; set; }
        public decimal CostemployerI { get; set; }
        public decimal Costother1I { get; set; }
        public decimal Costother2I { get; set; }
        public decimal Costother3I { get; set; }
        public decimal CosttotalI { get; set; }
        public decimal CostcobraI { get; set; }
        public decimal BenefitdeductibleI { get; set; }
        public decimal Bnpaypmx { get; set; }
        public decimal Bnfyrmax { get; set; }
        public decimal Bnflfmax { get; set; }
        public int DexRowId { get; set; }
    }
}
