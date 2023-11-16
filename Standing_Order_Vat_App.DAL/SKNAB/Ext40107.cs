using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40107
    {
        public string PtWindowId { get; set; } = null!;
        public byte SynchronizeCb { get; set; }
        public string Tabltech { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
