using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pdk03900
    {
        public string Noteid { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public int DexRowId { get; set; }
        public string Txtfield { get; set; } = null!;
    }
}
