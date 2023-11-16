namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class UserDataFilter
    {
        public int UserFilterId { get; set; }
        public int UserId { get; set; }
        public int FilterId { get; set; }

        public virtual DataFilter Filter { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
