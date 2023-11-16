using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa40101
    {
        public string Uomschdl { get; set; } = null!;
        public string Umschdsc { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Baseuofm { get; set; } = null!;
        public short Umdpqtys { get; set; }
        public int DexRowId { get; set; }
    }
}
