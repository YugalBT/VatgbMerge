using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl00100f1
    {
        public int Actindx { get; set; }
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
        public string Actalias { get; set; } = null!;
        public string Mnacsgmt { get; set; } = null!;
        public short Accttype { get; set; }
        public string Actdescr { get; set; } = null!;
        public short Accatnum { get; set; }
        public int Relid { get; set; }
        public int DexRowId { get; set; }
    }
}
