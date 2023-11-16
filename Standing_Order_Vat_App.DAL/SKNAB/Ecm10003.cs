using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ecm10003
    {
        public string PoReqNo { get; set; } = null!;
        public int SeqOrdId { get; set; }
        public string ItemId { get; set; } = null!;
        public string ItemDesc { get; set; } = null!;
        public string VendItemId { get; set; } = null!;
        public string VendItemDesc { get; set; } = null!;
        public string VendId { get; set; } = null!;
        public string VendName { get; set; } = null!;
        public decimal CommitAmt { get; set; }
        public short PoOrReq { get; set; }
        public int DexRowId { get; set; }
    }
}
