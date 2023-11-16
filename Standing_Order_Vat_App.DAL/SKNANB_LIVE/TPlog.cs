using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class TPlog
    {
        public string? UserName { get; set; }
        public string? MachineName { get; set; }
        public string? IpAddress { get; set; }
        public DateTime? LoginDate { get; set; }
        public bool? LoginStatus { get; set; }
    }
}
