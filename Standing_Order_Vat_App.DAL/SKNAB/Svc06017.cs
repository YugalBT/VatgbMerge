using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06017
    {
        public string Routeid { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public decimal Sequence1 { get; set; }
        public int Lnitmseq { get; set; }
        public string Cmptitnm { get; set; } = null!;
        public decimal Cmpitqty { get; set; }
        public int DexRowId { get; set; }
    }
}
