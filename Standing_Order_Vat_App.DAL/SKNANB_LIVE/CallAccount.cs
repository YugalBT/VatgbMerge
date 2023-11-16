using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class CallAccount
    {
        /// <summary>
        /// ID joined with Employees table.
        /// </summary>
        public int? IdEmployee { get; set; }
        /// <summary>
        /// name used non-employee accounts
        /// </summary>
        public string? AccountName { get; set; }
        public string AccountCode { get; set; } = null!;
        public bool Deleted { get; set; }

        public virtual Employee? IdEmployeeNavigation { get; set; }
    }
}
