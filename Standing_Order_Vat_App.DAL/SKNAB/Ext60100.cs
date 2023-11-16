using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext60100
    {
        public short SetupOption { get; set; }
        public byte SetupCb { get; set; }
        public int DexRowId { get; set; }
    }
}
