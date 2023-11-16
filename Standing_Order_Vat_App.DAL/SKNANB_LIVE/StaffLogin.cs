using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class StaffLogin
    {
        public string UserName { get; set; } = null!;
        public int? EmpId { get; set; }
        public string? PassWord { get; set; }
        public bool? ResetPw { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool? Locked { get; set; }
    }
}
