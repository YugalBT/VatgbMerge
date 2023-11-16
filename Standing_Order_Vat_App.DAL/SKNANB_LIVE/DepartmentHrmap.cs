using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class DepartmentHrmap
    {
        public int DepartmentHrmapId { get; set; }
        public string Deprtmnt { get; set; } = null!;
        public int DepartmentId { get; set; }
    }
}
