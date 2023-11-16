using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa01200
    {
        public int PhysicalInventoryIndex { get; set; }
        public string PhysicalLocationId { get; set; } = null!;
        public string AssetLabel { get; set; } = null!;
        public DateTime VerifiedDate { get; set; }
        public string Pin { get; set; } = null!;
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
