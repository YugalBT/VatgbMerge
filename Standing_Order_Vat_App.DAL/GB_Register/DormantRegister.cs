using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.GB_Register
{
    public partial class DormantRegister
    {
        public int RecordId { get; set; }
        public DateTime DateRequested { get; set; }
        public string AcctNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal? PreviousBalance { get; set; }
        public string? Particulars { get; set; }
        public int InitialIdEmployee { get; set; }
        public int? ReactivateIdEmployee { get; set; }
        public DateTime? DatePerformed { get; set; }
        public int? EntryStatusId { get; set; }
        public int? AcctTypeId { get; set; }
        public string? CoreBranchNumber { get; set; }
        public int? IssuingDeptId { get; set; }
        public string? AcctStatus { get; set; }
        public string? AcctType { get; set; }

        public virtual AccountType? AcctTypeNavigation { get; set; }
        public virtual EntryStatus? EntryStatus { get; set; }
    }
}
