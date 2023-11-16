using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop40600
    {
        public string Curncyid { get; set; } = null!;
        public short Decplcur { get; set; }
        public int DexRowId { get; set; }
    }
}
