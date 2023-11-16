using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01601
    {
        public decimal Pabillnoteidx { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public int DexRowId { get; set; }
        public string Patx500 { get; set; } = null!;
    }
}
