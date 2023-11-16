using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Lk000101
    {
        public int LkLinkNo { get; set; }
        public short Status { get; set; }
        public string Userid { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
