using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Lk000102
    {
        public int LkLinkNo { get; set; }
        public string Dscriptn { get; set; } = null!;
        public DateTime LkLinkDate { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Lstdtedt { get; set; }
        public decimal LkLinkBalance { get; set; }
        public string Userid { get; set; } = null!;
        public string Lstusred { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
