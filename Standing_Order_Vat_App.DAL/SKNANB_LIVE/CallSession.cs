using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class CallSession
    {
        public int SessionId { get; set; }
        /// <summary>
        /// name used for non-employee accounts
        /// </summary>
        public string? AccountName { get; set; }
        public string AccountCode { get; set; } = null!;
        public int? IdHistory { get; set; }
        public int? IdEmployee { get; set; }

        public virtual EmployeeHistory? IdHistoryNavigation { get; set; }
    }
}
