using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Vat10001
    {
        public string Ccode { get; set; } = null!;
        public string CcodeDesc { get; set; } = null!;
        public byte Ecflag { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
