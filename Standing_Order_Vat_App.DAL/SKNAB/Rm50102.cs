using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm50102
    {
        public string Userid { get; set; } = null!;
        public short Prcssqnc { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Rcpients { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public int DexRowId { get; set; }
    }
}
