using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa05200
    {
        public string Paprojnumber { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string PafeeId { get; set; } = null!;
        public DateTime Padt { get; set; }
        public decimal PafeeAmount { get; set; }
        public decimal PaamountBilled { get; set; }
        public string Pachgordno { get; set; } = null!;
        public decimal PaMcFeeAmount { get; set; }
        public decimal PaMcAmountBilled { get; set; }
        public int DexRowId { get; set; }
    }
}
