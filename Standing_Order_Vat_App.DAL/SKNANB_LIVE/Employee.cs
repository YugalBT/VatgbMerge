using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class Employee
    {
        public Employee()
        {
            CallAccounts = new HashSet<CallAccount>();
            EarningTypes = new HashSet<EarningType>();
            EmployeeHistories = new HashSet<EmployeeHistory>();
            EmployeePerformanceHistories = new HashSet<EmployeePerformanceHistory>();
            EmployeePerformances = new HashSet<EmployeePerformance>();
            StaffPerformanceHistories = new HashSet<StaffPerformanceHistory>();
        }

        public int IdEmployee { get; set; }
        public string? IdStaffNo { get; set; }
        public int IdProfile { get; set; }
        public int IdEmpType { get; set; }
        public int IdEmpMngr { get; set; }
        public string InInactive { get; set; } = null!;
        public int? IdDivision { get; set; }
        public int IdCompany { get; set; }
        public int IdBranch { get; set; }
        public int? IdDept { get; set; }
        public int? IdAcctType { get; set; }
        public DateTime? DtHired { get; set; }
        public DateTime? DtTerm { get; set; }
        public int? IdGrade { get; set; }
        public decimal? MnyRtOvrtime { get; set; }
        public DateTime? DtEndProb { get; set; }
        public string? TxJobTitle { get; set; }
        public string? TxJobDesc { get; set; }
        public decimal? MnyPayReg { get; set; }
        public decimal? MnyPayMonth { get; set; }
        public string? AcPay { get; set; }
        public string InIsStaff { get; set; } = null!;
        public string InDelFlg { get; set; } = null!;
        public int? IdAlt { get; set; }
        public int? IdHistory { get; set; }
        public string? NmEmployeeCode { get; set; }

        public virtual Company IdCompanyNavigation { get; set; } = null!;
        public virtual EmployeeGroup IdEmpTypeNavigation { get; set; } = null!;
        public virtual Profile IdProfileNavigation { get; set; } = null!;
        public virtual ICollection<CallAccount> CallAccounts { get; set; }
        public virtual ICollection<EarningType> EarningTypes { get; set; }
        public virtual ICollection<EmployeeHistory> EmployeeHistories { get; set; }
        public virtual ICollection<EmployeePerformanceHistory> EmployeePerformanceHistories { get; set; }
        public virtual ICollection<EmployeePerformance> EmployeePerformances { get; set; }
        public virtual ICollection<StaffPerformanceHistory> StaffPerformanceHistories { get; set; }
    }
}
