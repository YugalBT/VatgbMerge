namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class ApplicationUserDataFilter
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int UserId { get; set; }
        public int FilterId { get; set; }
        public string Permission { get; set; } = null!;

        public virtual ApplicationDataFilter ApplicationDataFilter { get; set; } = null!;
        public virtual ApplicationUserRole ApplicationUserRole { get; set; } = null!;
    }
}
