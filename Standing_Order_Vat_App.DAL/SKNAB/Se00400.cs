using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Se00400
    {
        public string Userid { get; set; } = null!;
        public string Actnumbr1 { get; set; } = null!;
        public string Actnumbr2 { get; set; } = null!;
        public string Actnumbr3 { get; set; } = null!;
        public string Actnumbr4 { get; set; } = null!;
        public string Actnumbr5 { get; set; } = null!;
        public string Actnumbr6 { get; set; } = null!;
        public string Actnumbr7 { get; set; } = null!;
        public string Actnumbr8 { get; set; } = null!;
        public string Actnumbr9 { get; set; } = null!;
        public string Actnumbr10 { get; set; } = null!;
        public short SeZeroNm { get; set; }
        public short SeZeroPb { get; set; }
        public decimal Netamnt { get; set; }
        public decimal Perdblnc { get; set; }
        public short Sesorno1 { get; set; }
        public string Sesort1 { get; set; } = null!;
        public short Openyear { get; set; }
        public int Actindx { get; set; }
        public int DexRowId { get; set; }
    }
}
