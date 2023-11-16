namespace Standing_Order_Vat_App.DAL.CoreData_DB
{
    public partial class DayTrnFormat
    {
        public string Code { get; set; } = null!;
        public int FieldLength { get; set; }
        public string Description { get; set; } = null!;
        public int? FieldStartPosition { get; set; }
    }
}
