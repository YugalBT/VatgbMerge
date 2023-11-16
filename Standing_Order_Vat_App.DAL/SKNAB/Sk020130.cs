using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sk020130
    {
        public short QueryIndex { get; set; }
        public string QueryName { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
