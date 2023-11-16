using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class GetBfwdInfo
    {
        public string? NmFirst { get; set; }
        public string? NmLast { get; set; }
        public string? AbsentType { get; set; }
        public int? Year { get; set; }
        public int? Value { get; set; }
    }
}
