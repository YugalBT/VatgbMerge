using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl40100
    {
        public string Bsnsfmid { get; set; } = null!;
        public string Bsnsfdsc { get; set; } = null!;
        public int Offindx { get; set; }
        public byte Ovoacnum { get; set; }
        public byte[] Bchemsg1 { get; set; } = null!;
        public byte[] Bchemsg2 { get; set; } = null!;
        public string Sourcdoc { get; set; } = null!;
        public string Refrence { get; set; } = null!;
        public byte Brkdnall { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
