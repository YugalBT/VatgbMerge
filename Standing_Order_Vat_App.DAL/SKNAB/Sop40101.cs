using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop40101
    {
        public short Sopstatus { get; set; }
        public string Sopstsdescr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
