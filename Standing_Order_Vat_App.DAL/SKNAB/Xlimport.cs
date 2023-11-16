using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Xlimport
    {
        public string Userid { get; set; } = null!;
        public string Budgetid { get; set; } = null!;
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
        public short Periodid { get; set; }
        public decimal Budgetamt { get; set; }
        public short Accatnum { get; set; }
        public int Actindx { get; set; }
        public int DexRowId { get; set; }
    }
}
