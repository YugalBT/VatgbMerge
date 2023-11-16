using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class EarningType
    {
        public int EarningTypeId { get; set; }
        public int EmployeeId { get; set; }
        public int TypeId { get; set; }
        public string DepositAccount { get; set; } = null!;
        public int AccountType { get; set; }
        public string AmountType { get; set; } = null!;
        public decimal Amount { get; set; }
        public bool? Active { get; set; }
        public bool Deleted { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
