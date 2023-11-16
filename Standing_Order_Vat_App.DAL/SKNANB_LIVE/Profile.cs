using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class Profile
    {
        public Profile()
        {
            Addresses = new HashSet<Address>();
            EmployeeHistories = new HashSet<EmployeeHistory>();
            Employees = new HashSet<Employee>();
            Horizon55s = new HashSet<Horizon55>();
            VisaCards = new HashSet<VisaCard>();
        }

        public int IdProfile { get; set; }
        public int? IdSocialSec { get; set; }
        public string? NmFirst { get; set; }
        public string? NmLast { get; set; }
        public string? NmFull { get; set; }
        public string? InGender { get; set; }
        public string? TxSalutation { get; set; }
        public DateTime? DtDob { get; set; }
        public string? InMaritalStatus { get; set; }
        public string? NmSpouse { get; set; }
        public string? PhPrimaryNo { get; set; }
        public string? TxEmail { get; set; }
        public string? InDelFlg { get; set; }
        public int? IdAddress { get; set; }
        public int? IdCompany { get; set; }
        public int IdCif { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<EmployeeHistory> EmployeeHistories { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Horizon55> Horizon55s { get; set; }
        public virtual ICollection<VisaCard> VisaCards { get; set; }
    }
}
