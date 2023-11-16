namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class User
    {
        public User()
        {
            ApplicationUserRoleModules = new HashSet<ApplicationUserRoleModule>();
            ApplicationUserRoles = new HashSet<ApplicationUserRole>();
            UserDataFilters = new HashSet<UserDataFilter>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public string Path { get; set; } = null!;
        public int EmployeeId { get; set; }
        public string AccessCode { get; set; } = null!;
        public bool Online { get; set; }
        public bool IsDelete { get; set; }

        public virtual ICollection<ApplicationUserRoleModule> ApplicationUserRoleModules { get; set; }
        public virtual ICollection<ApplicationUserRole> ApplicationUserRoles { get; set; }
        public virtual ICollection<UserDataFilter> UserDataFilters { get; set; }
    }
}
