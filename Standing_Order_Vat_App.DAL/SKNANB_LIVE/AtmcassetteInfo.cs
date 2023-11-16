using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class AtmcassetteInfo
    {
        public string? Description { get; set; }
        public int? Type1 { get; set; }
        public int? Type2 { get; set; }
        public int? Type3 { get; set; }
        public int? Type4 { get; set; }
        public int? Number { get; set; }
        public DateTime? LastCleared { get; set; }
        public string? Machine { get; set; }
        public int? AtmNumber { get; set; }
        public int EntryId { get; set; }
    }
}
