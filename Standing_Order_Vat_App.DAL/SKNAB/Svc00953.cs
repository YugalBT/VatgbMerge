using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00953
    {
        public string Locncode { get; set; } = null!;
        public string Timezone { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
