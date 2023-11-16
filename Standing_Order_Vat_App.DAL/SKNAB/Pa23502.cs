using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa23502
    {
        public string Pacontnumber { get; set; } = null!;
        public string Pachgordno { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public short Pasequencenumber { get; set; }
        public string PafeeId { get; set; } = null!;
        public DateTime Padt { get; set; }
        public DateTime Paprevdate { get; set; }
        public decimal PafeeAmount { get; set; }
        public decimal Paprevfeeamt { get; set; }
        public decimal PaamountBilled { get; set; }
        public int DexRowId { get; set; }
    }
}
