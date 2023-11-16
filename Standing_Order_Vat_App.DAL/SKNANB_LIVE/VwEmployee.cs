using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VwEmployee
    {
        public string? NmFirst { get; set; }
        public string? NmLast { get; set; }
        public int? IdSocialSec { get; set; }
        public int IdEmployee { get; set; }
        public int IdBranch { get; set; }
        public int IdCompany { get; set; }
        public int? IdDivision { get; set; }
        public int? IdGrade { get; set; }
        public string? TxJobTitle { get; set; }
        public int? IdDept { get; set; }
        public string Division { get; set; } = null!;
        public string Department { get; set; } = null!;
        public int IdEmpMngr { get; set; }
    }
}
