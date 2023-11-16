using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy00700
    {
        public string Notename { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public string Dsplname { get; set; } = null!;
        public int DexRowId { get; set; }
        public string Txtfield { get; set; } = null!;
    }
}
