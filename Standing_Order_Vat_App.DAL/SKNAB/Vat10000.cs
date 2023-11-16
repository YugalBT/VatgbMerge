using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Vat10000
    {
        public string Tcc { get; set; } = null!;
        public string Taxcomdesc { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public byte Supuntreqd { get; set; }
        public int DexRowId { get; set; }
    }
}
