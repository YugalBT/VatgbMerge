using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext00101
    {
        public string PtWindowId { get; set; } = null!;
        public string PtUdKey { get; set; } = null!;
        public short PtUdNumber { get; set; }
        public string Strga255 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
