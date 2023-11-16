using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr40801
    {
        public string Benefit { get; set; } = null!;
        public short Borcdtyp { get; set; }
        public string Bsdoncde { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
