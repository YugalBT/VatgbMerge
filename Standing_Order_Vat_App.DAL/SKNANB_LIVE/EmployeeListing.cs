using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class EmployeeListing
    {
        public string NmCompany { get; set; } = null!;
        public string? Name { get; set; }
        public int? IdSocialSec { get; set; }
        public DateTime? DtDob { get; set; }
        public string? TxJobTitle { get; set; }
        public string? TxAddr1 { get; set; }
        public string? TxAddr2 { get; set; }
        public string? NmCity { get; set; }
        public string? NmCountry { get; set; }
        public string? PhPhone1 { get; set; }
        public int? CdZip { get; set; }
    }
}
