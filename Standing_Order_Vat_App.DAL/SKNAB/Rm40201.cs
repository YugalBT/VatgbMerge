using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm40201
    {
        public short Index1 { get; set; }
        public string Rmperdsc { get; set; } = null!;
        public short Rmperend { get; set; }
        public int DexRowId { get; set; }
    }
}
