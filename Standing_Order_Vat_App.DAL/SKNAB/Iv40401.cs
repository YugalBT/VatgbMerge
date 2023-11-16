using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv40401
    {
        public string Itmclscd { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Decplcur { get; set; }
        public int DexRowId { get; set; }
    }
}
