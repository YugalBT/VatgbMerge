namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class ApplicationUserRole
    {
        public ApplicationUserRole()
        {
            ApplicationUserDataFilters = new HashSet<ApplicationUserDataFilter>();
            ApplicationUserModules = new HashSet<ApplicationUserModule>();
        }

        public int UserApplicationId { get; set; }
        public int UserId { get; set; }
        public int ApplicationId { get; set; }
        public int RoleId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<ApplicationUserDataFilter> ApplicationUserDataFilters { get; set; }
        public virtual ICollection<ApplicationUserModule> ApplicationUserModules { get; set; }
    }
}
