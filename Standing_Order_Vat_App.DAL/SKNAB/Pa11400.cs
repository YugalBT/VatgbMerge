using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa11400
    {
        public string Padocnumber20 { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public short Paprojnttyp { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public int DexRowId { get; set; }
    }
}
