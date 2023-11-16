using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00913
    {
        public string Srvstat { get; set; } = null!;
        public string Stsdescr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
