using System.ComponentModel.DataAnnotations;

namespace Standing_Order_Vat_App.DAL.Sp_DirectoryDB
{
    public class Sp_userRole
    {
        [Key]
        public int UserID { get; set; }
        public string? UserName { get; set; }
        public string? DisplayName { get; set; }
        public int ApplicationID { get; set; }
        public string? ApplicationName { get; set; }
        public int RoleID { get; set; }
        public string? RoleName { get; set; }
        public int EmployeeID { get; set; }
    }
}
