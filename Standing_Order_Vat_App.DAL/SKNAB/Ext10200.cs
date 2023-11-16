using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext10200
    {
        public int LookupNumber { get; set; }
        public short ExtenderType { get; set; }
        public string ExtenderId { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
