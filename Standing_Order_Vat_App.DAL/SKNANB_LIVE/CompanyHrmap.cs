using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class CompanyHrmap
    {
        public int CompanyHrmapId { get; set; }
        public string DivisioncodeI { get; set; } = null!;
        public int CompanyId { get; set; }
    }
}
