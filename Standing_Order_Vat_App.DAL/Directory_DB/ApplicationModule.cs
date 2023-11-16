namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class ApplicationModule
    {
        public ApplicationModule()
        {
            ApplicationRoleModules = new HashSet<ApplicationRoleModule>();
            ApplicationUserModules = new HashSet<ApplicationUserModule>();
            ApplicationUserRoleModules = new HashSet<ApplicationUserRoleModule>();
        }

        public int ApplicationModuleId { get; set; }
        public int ModuleId { get; set; }
        public int ApplicationId { get; set; }

        public virtual Application Application { get; set; } = null!;
        public virtual Module Module { get; set; } = null!;
        public virtual ICollection<ApplicationRoleModule> ApplicationRoleModules { get; set; }
        public virtual ICollection<ApplicationUserModule> ApplicationUserModules { get; set; }
        public virtual ICollection<ApplicationUserRoleModule> ApplicationUserRoleModules { get; set; }
    }
}
