using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me142804
    {
        public string Arnum { get; set; } = null!;
        public string Meardlid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public int MeArecLineNumber { get; set; }
        public string Ermsgtxt { get; set; } = null!;
        public string MeUnprocessedLine { get; set; } = null!;
        public string MeUnprocessedLineStat { get; set; } = null!;
        public DateTime Userdate { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
