using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop10205
    {
        public string Prcbkid { get; set; } = null!;
        public string Prodtcod { get; set; } = null!;
        public string Linkcode { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public int DexRowId { get; set; }
    }
}
