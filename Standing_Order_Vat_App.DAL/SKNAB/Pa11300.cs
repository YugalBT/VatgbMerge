using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa11300
    {
        public string Padocnumber20 { get; set; } = null!;
        public string Pacontnumber { get; set; } = null!;
        public short Pacontnttyp { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public int DexRowId { get; set; }
    }
}
