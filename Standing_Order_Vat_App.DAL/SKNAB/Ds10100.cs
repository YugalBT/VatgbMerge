using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ds10100
    {
        public int Actindx { get; set; }
        public string? Accatdsc { get; set; }
        public short Accatnum { get; set; }
        public string Actnumst { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
