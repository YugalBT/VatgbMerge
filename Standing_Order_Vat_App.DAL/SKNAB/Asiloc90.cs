using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Asiloc90
    {
        public short Setupkey { get; set; }
        public byte AsiShowInactive { get; set; }
        public string AsiQlKeyLabel1 { get; set; } = null!;
        public string AsiQlKeyLabel2 { get; set; } = null!;
        public string AsiQlKeyLabel3 { get; set; } = null!;
        public string AsiQlKeyLabel4 { get; set; } = null!;
        public short AsiQlKeyFieldId1 { get; set; }
        public short AsiQlKeyFieldId2 { get; set; }
        public short AsiQlKeyFieldId3 { get; set; }
        public short AsiQlKeyFieldId4 { get; set; }
        public int DexRowId { get; set; }
    }
}
