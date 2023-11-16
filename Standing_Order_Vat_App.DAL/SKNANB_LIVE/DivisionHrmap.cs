using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class DivisionHrmap
    {
        public int DivisionHrmapId { get; set; }
        public string Deprtmnt { get; set; } = null!;
        public int DivisionId { get; set; }
    }
}
