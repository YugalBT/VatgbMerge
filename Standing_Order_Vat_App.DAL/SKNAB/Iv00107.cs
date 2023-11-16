using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv00107
    {
        public string Itemnmbr { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public string Prclevel { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public decimal Rndgamnt { get; set; }
        public short Roundhow { get; set; }
        public short Roundto { get; set; }
        public short Umslsopt { get; set; }
        public decimal Qtybsuom { get; set; }
        public int DexRowId { get; set; }
    }
}
