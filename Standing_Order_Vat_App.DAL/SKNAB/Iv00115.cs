using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv00115
    {
        public string Itemnmbr { get; set; } = null!;
        public string Manufacturer { get; set; } = null!;
        public string Mnfctritmnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public byte Primaryitem { get; set; }
        public int DexRowId { get; set; }
    }
}
