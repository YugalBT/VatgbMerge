using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40106
    {
        public string PtWindowId { get; set; } = null!;
        public short PtExplorerProductId { get; set; }
        public short PtExplorerObject { get; set; }
        public string Keyfield { get; set; } = null!;
        public short ExplorerObjectFieldId { get; set; }
        public int DexRowId { get; set; }
    }
}
