using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class InactiveAtt
    {
        public int IdEmployee { get; set; }
        public string? NmFull { get; set; }
        public string InInactive { get; set; } = null!;
    }
}
