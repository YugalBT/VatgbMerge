using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrsax022
    {
        public short TableI { get; set; }
        public string Dscriptn { get; set; } = null!;
        public short CompensationperiodI { get; set; }
        public int DexRowId { get; set; }
    }
}
