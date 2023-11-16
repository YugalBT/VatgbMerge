using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa42400
    {
        public int PhysicalLocationIndex { get; set; }
        public string PhysicalLocationId { get; set; } = null!;
        public string PhysicalLocationDesc { get; set; } = null!;
        public string Locatnid { get; set; } = null!;
        public DateTime LastInventoryDate { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
