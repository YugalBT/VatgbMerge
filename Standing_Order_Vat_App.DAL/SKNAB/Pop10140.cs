using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop10140
    {
        public string Ponumber { get; set; } = null!;
        public int Ord { get; set; }
        public string Manufacturer { get; set; } = null!;
        public string Mnfctritmnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public byte Changed { get; set; }
        public byte Includeitem { get; set; }
        public int DexRowId { get; set; }
    }
}
