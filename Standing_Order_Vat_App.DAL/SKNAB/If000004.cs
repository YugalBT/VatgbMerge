using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class If000004
    {
        public string Userid { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public int Jrnentry { get; set; }
        public decimal Sqncline { get; set; }
        public int DexRowId { get; set; }
    }
}
