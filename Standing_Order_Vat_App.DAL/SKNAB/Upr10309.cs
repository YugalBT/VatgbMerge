using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10309
    {
        public short Pyrlctyp { get; set; }
        public int Pyrlcnbr { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
