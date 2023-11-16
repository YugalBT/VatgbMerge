using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy03900
    {
        public decimal Noteindx { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public int DexRowId { get; set; }
        public string Txtfield { get; set; } = null!;
    }
}
