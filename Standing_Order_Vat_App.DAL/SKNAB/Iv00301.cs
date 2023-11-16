using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv00301
    {
        public string Itemnmbr { get; set; } = null!;
        public string Lotnumbr { get; set; } = null!;
        public string Lotatrb1 { get; set; } = null!;
        public string Lotatrb2 { get; set; } = null!;
        public string Lotatrb3 { get; set; } = null!;
        public DateTime Lotatrb4 { get; set; }
        public DateTime Lotatrb5 { get; set; }
        public short Iuscount { get; set; }
        public short Rcrdstts { get; set; }
        public int DexRowId { get; set; }
    }
}
