using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Vat10007
    {
        public short Intrstttyp { get; set; }
        public string Intrsttfld { get; set; } = null!;
        public string Intrsttflddsc { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
