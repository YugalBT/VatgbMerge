using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc10300
    {
        public string Bachnumb { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public string Dscrptn { get; set; } = null!;
        public byte InUse { get; set; }
        public int DexRowId { get; set; }
    }
}
