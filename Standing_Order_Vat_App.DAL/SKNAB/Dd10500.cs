using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Dd10500
    {
        public short Index1 { get; set; }
        public short Dditem { get; set; }
        public string Employid { get; set; } = null!;
        public string Ddtrans { get; set; } = null!;
        public string Ddtranum { get; set; } = null!;
        public string Ddactnum { get; set; } = null!;
        public decimal Ddamtdlr { get; set; }
        public string Ddindid { get; set; } = null!;
        public string Ddindnam { get; set; } = null!;
        public string Ddtrace { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
