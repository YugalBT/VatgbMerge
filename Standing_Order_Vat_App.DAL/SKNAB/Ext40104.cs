using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40104
    {
        public string PtWindowId { get; set; } = null!;
        public short FieldNumber { get; set; }
        public int LookupNumber { get; set; }
        public short LinkNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
