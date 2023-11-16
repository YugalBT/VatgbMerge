using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class ManagerType
    {
        public string Description { get; set; } = null!;
        public bool IsValid { get; set; }
        public long NumKey { get; set; }
    }
}
