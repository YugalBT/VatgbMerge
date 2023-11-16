using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class View1
    {
        public int IdEmployee { get; set; }
        public int EmpId { get; set; }
        public string InInactive { get; set; } = null!;
        public string? NmFirst { get; set; }
        public string? NmLast { get; set; }
    }
}
