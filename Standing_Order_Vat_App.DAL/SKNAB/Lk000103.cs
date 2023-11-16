using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Lk000103
    {
        public int LkLinkNo { get; set; }
        public short LineNumber { get; set; }
        public int Jrnentry { get; set; }
        public int Actindx { get; set; }
        public int Seqnumbr { get; set; }
        public decimal Trxamnt { get; set; }
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
        public short Openyear { get; set; }
        public short Currnidx { get; set; }
        public decimal Rctrxseq { get; set; }
        public DateTime Trxdate { get; set; }
        public int DexRowId { get; set; }
    }
}
