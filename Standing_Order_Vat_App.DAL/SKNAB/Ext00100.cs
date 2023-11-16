using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext00100
    {
        public string PtWindowId { get; set; } = null!;
        public string PtUdKey { get; set; } = null!;
        public string KeyStrings1 { get; set; } = null!;
        public string KeyStrings2 { get; set; } = null!;
        public string KeyStrings3 { get; set; } = null!;
        public string KeyStrings4 { get; set; } = null!;
        public string KeyStrings5 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
