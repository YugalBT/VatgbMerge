using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc01101
    {
        public string Spltterms { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Dlrorpct { get; set; } = null!;
        public decimal Listprce { get; set; }
        public short Typeid { get; set; }
        public string Srvstat { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
