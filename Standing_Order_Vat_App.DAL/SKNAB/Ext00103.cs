using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext00103
    {
        public string PtWindowId { get; set; } = null!;
        public string PtUdKey { get; set; } = null!;
        public short PtUdNumber { get; set; }
        public decimal Total { get; set; }
        public int DexRowId { get; set; }
    }
}
