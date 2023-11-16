using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; } = null!;
        public string CoreId { get; set; } = null!;
    }
}
