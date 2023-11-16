using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa10200
    {
        public string Userid { get; set; } = null!;
        public string Groupname { get; set; } = null!;
        public int Assetindex { get; set; }
        public string Assetid { get; set; } = null!;
        public short Assetidsuf { get; set; }
        public string Assetdesc { get; set; } = null!;
        public string Assetclassid { get; set; } = null!;
        public string Locatnid { get; set; } = null!;
        public string Structureid { get; set; } = null!;
        public short Assetstatus { get; set; }
        public string AssetLabel { get; set; } = null!;
        public string PhysicalLocationId { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
