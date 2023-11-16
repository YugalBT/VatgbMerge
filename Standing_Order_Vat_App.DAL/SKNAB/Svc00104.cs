using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00104
    {
        public string Techid { get; set; } = null!;
        public string Svcarea { get; set; } = null!;
        public DateTime Lstdtedt { get; set; }
        public int DexRowId { get; set; }
    }
}
