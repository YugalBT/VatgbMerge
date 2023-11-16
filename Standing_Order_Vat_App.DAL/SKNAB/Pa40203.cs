using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa40203
    {
        public string Paptid { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string PafeeId { get; set; } = null!;
        public DateTime Padt { get; set; }
        public decimal PafeeAmount { get; set; }
        public int DexRowId { get; set; }
    }
}
