using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Lk000005
    {
        public string LkGroup { get; set; } = null!;
        public int LkLinkNo { get; set; }
        public int DexRowId { get; set; }
    }
}
