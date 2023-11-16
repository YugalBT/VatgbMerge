using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pp300001
    {
        public short PpModule { get; set; }
        public short Disttype { get; set; }
        public byte PpDisWarning { get; set; }
        public int DexRowId { get; set; }
    }
}
