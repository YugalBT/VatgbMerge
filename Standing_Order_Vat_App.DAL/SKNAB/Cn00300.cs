using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn00300
    {
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
        public string Txtfield { get; set; } = null!;
    }
}
