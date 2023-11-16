using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2dis03
    {
        public string EmpidI { get; set; } = null!;
        public DateTime IdateI { get; set; }
        public short Hrstatus { get; set; }
        public int DexRowId { get; set; }
    }
}
