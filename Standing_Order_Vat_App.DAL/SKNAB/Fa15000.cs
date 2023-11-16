using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa15000
    {
        public string Glintbtchnum { get; set; } = null!;
        public DateTime Glinttrxdate { get; set; }
        public string GlInterfaceComment { get; set; } = null!;
        public short GlIntfBeginPeriod { get; set; }
        public short GlInterfaceBeginYear { get; set; }
        public short GlInterfaceEndPeriod { get; set; }
        public short GlInterfaceEndYear { get; set; }
        public int Bookindx { get; set; }
        public int Jrnentry { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
