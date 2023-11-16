using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class EmployeeHistory
    {
        public int IdHistory { get; set; }
        public int IdEmployee { get; set; }
        public int IdProfile { get; set; }
        public int IdEmpType { get; set; }
        public int IdEmpMngr { get; set; }
        public int? IdDivision { get; set; }
        public int IdCompany { get; set; }
        public int IdBranch { get; set; }
        public int? IdDept { get; set; }
        public int? IdAcctType { get; set; }
        public DateTime? DtHired { get; set; }
        public DateTime? DtTerm { get; set; }
        public int? IdGrade { get; set; }
        public decimal? MnyRtOvrtime { get; set; }
        public string? TxJobTitle { get; set; }
        public string? TxJobDesc { get; set; }
        public decimal? MnyPayReg { get; set; }
        public decimal? MnyPayMonth { get; set; }
        public string? AcPay { get; set; }
        public string InIsStaff { get; set; } = null!;
        public DateTime HistoryTimestamp { get; set; }
        public string HistoryUser { get; set; } = null!;

        public virtual Company IdCompanyNavigation { get; set; } = null!;
        public virtual EmployeeGroup IdEmpTypeNavigation { get; set; } = null!;
        public virtual Employee IdEmployeeNavigation { get; set; } = null!;
        public virtual Profile IdProfileNavigation { get; set; } = null!;
    }
}
