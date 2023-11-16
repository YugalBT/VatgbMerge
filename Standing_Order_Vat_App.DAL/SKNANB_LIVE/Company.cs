using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class Company
    {
        public Company()
        {
            EmployeeHistories = new HashSet<EmployeeHistory>();
            Employees = new HashSet<Employee>();
            Glaccounts = new HashSet<Glaccount>();
        }

        public int IdCompany { get; set; }
        public string NmCompany { get; set; } = null!;
        public int IdDefaultGrp { get; set; }
        public string NmRegNo { get; set; } = null!;
        public string NmTrade { get; set; } = null!;
        public int? IdManager { get; set; }
        public string? TxDesc { get; set; }
        public string InDelFlg { get; set; } = null!;
        public string? NmNickname { get; set; }

        public virtual ICollection<EmployeeHistory> EmployeeHistories { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Glaccount> Glaccounts { get; set; }
    }
}
