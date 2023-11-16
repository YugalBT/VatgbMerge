using Standing_Order_Vat_App.DAL.Sp_DirectoryDB;
using System.ComponentModel.DataAnnotations;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class UserRole_VM
    {
        public static explicit operator UserRole_VM(Sp_userRole item)
        {
            return new UserRole_VM
            {
                ApplicationID = item.ApplicationID,
                RoleID = item.RoleID,
                RoleName = item.RoleName,
                ApplicationName = item.ApplicationName,
                DisplayName = item.DisplayName,
                EmployeeID = item.EmployeeID,
                UserID = item.UserID,
                UserName = item.UserName,
            };
        }
        [Key]
        public int UserID { get; set; }
        public string? UserName { get; set; }
        public string? DisplayName { get; set; }
        public int ApplicationID { get; set; }
        public string? ApplicationName { get; set; }
        public int RoleID { get; set; }
        public string? RoleName { get; set; }
        public int EmployeeID { get; set; }
        //   public virtual List<StandingOrder_VM>? StandingOrder { get; set; }
        public Sp_userRole ToSp_userRoleDbModel()
        {
            return new Sp_userRole
            {
                ApplicationID = ApplicationID,
                UserName = UserName,
                UserID = UserID,
                EmployeeID = EmployeeID,
                DisplayName = DisplayName,
                RoleName = RoleName,
                RoleID = RoleID,
                ApplicationName = ApplicationName
            };
        }
    }
}
