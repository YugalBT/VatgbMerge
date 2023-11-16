namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class ApplicationRoleModule
    {
        public int RoleModuleId { get; set; }
        public int ApplicationId { get; set; }
        public int RoleId { get; set; }
        public int ModuleId { get; set; }
        public string Permission { get; set; } = null!;

        public virtual ApplicationModule ApplicationModule { get; set; } = null!;
        public virtual ApplicationRole ApplicationRole { get; set; } = null!;
    }
}
