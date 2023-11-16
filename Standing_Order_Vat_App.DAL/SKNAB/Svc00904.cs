using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00904
    {
        public short PriorityLevel { get; set; }
        public string Dscriptn { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
