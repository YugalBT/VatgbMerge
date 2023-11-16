using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Dd10300
    {
        public string Employid { get; set; } = null!;
        public short Index1 { get; set; }
        public short DdarrayIndex { get; set; }
        public short Dditem { get; set; }
        public short Ddindex { get; set; }
        public int DexRowId { get; set; }
    }
}
