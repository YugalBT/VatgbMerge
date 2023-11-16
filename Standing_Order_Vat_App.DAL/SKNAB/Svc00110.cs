using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00110
    {
        public string Pricelvl { get; set; } = null!;
        public byte Rtrnable { get; set; }
        public decimal SvcStandardPercent { get; set; }
        public decimal SvcOvertimePercent { get; set; }
        public decimal SvcDoublePercent { get; set; }
        public decimal SvcHotlinePercent { get; set; }
        public decimal SvcTravelPercent { get; set; }
        public decimal SvcReturnPercent { get; set; }
        public int DexRowId { get; set; }
    }
}
