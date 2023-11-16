using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc8005
    {
        public string Schedid { get; set; } = null!;
        public string Scheddesc { get; set; } = null!;
        public string Srvtype { get; set; } = null!;
        public string Uomschdl { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
