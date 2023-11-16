using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40105
    {
        public string PtWindowId { get; set; } = null!;
        public short Prodid { get; set; }
        public short PtExplorerObject { get; set; }
        public short PtExplorerNumberPrefi { get; set; }
        public int DexRowId { get; set; }
    }
}
