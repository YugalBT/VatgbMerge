using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class If000005
    {
        public string Userid { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public int Jrnentry { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public int DexRowId { get; set; }
    }
}
