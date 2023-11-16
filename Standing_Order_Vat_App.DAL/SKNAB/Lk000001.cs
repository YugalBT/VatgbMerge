using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Lk000001
    {
        public short Keynumbr { get; set; }
        public byte LkZeroBalance { get; set; }
        public DateTime LkArchiveDate { get; set; }
        public byte LkSingleAccount { get; set; }
        public byte LkAllowDelete { get; set; }
        public string LkPassword { get; set; } = null!;
        public int LkNextLinkNo { get; set; }
        public byte LkReUseLinks { get; set; }
        public int DexRowId { get; set; }
    }
}
