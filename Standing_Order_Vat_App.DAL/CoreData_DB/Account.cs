namespace Standing_Order_Vat_App.DAL.CoreData_DB
{
    public partial class Account
    {
        public long Number { get; set; }
        public int? Type { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? DateOpened { get; set; }
        public DateTime? BalanceDate { get; set; }
        public string? Status { get; set; }
        public int? Cif { get; set; }
        public int? CustId { get; set; }
        public int AccId { get; set; }
        public int? CurrId { get; set; }
    }
}
