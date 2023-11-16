using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Se000100
    {
        public string Userid { get; set; } = null!;
        public short Periodid { get; set; }
        public string Pername { get; set; } = null!;
        public decimal SeNetAmount1 { get; set; }
        public decimal SeNetAmount2 { get; set; }
        public decimal SeNetAmount3 { get; set; }
        public decimal SeNetAmount4 { get; set; }
        public decimal SePeriodBalance1 { get; set; }
        public decimal SePeriodBalance2 { get; set; }
        public decimal SePeriodBalance3 { get; set; }
        public decimal SePeriodBalance4 { get; set; }
        public short Securidx1 { get; set; }
        public short Securidx2 { get; set; }
        public short Securidx3 { get; set; }
        public short Securidx4 { get; set; }
        public int DexRowId { get; set; }
    }
}
