using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class StaffEnt
    {
        public int? IdSocialSec { get; set; }
        public int? IdGrade { get; set; }
        public string? NmFull { get; set; }
        public DateTime? DtHired { get; set; }
        public int? VacEnt { get; set; }
    }
}
