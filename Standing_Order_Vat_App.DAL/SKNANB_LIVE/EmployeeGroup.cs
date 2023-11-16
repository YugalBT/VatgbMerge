using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class EmployeeGroup
    {
        public EmployeeGroup()
        {
            EmployeeHistories = new HashSet<EmployeeHistory>();
            Employees = new HashSet<Employee>();
            Glaccounts = new HashSet<Glaccount>();
        }

        public int IdEmpGroup { get; set; }
        public string NmEmpGroup { get; set; } = null!;
        public int GlSwExps { get; set; }
        public int GlRegularPay { get; set; }
        public int GlSsEmpee { get; set; }
        public int GlSlEmpee { get; set; }
        public int GlSsLiable { get; set; }
        public string GlSsExps { get; set; } = null!;
        public int GlSlExps { get; set; }
        public string GlSlLiable { get; set; } = null!;
        public int GlOvertime { get; set; }
        public int CyPayment { get; set; }
        public string InDelFlg { get; set; } = null!;
        public int IdCompany { get; set; }

        public virtual ICollection<EmployeeHistory> EmployeeHistories { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Glaccount> Glaccounts { get; set; }
    }
}
