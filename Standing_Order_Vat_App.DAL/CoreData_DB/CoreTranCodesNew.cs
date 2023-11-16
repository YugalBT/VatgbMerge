namespace Standing_Order_Vat_App.DAL.CoreData_DB
{
    public partial class CoreTranCodesNew
    {
        public int Code { get; set; }
        public string Description { get; set; } = null!;
        public string? Abbr { get; set; }
        public string? DbCr { get; set; }
    }
}
