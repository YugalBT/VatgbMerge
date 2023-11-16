using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class ActiveEmp
    {
        public int IdEmployee { get; set; }
        public string InInactive { get; set; } = null!;
        public int IdCompany { get; set; }
        public string? NmFull { get; set; }
        public string? InDelFlg { get; set; }
    }
}
