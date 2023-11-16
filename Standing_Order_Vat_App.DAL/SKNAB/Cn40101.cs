using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn40101
    {
        public short Setupkey { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
