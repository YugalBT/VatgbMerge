namespace Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB
{
    public partial class CurrencyAcct
    {
        public int Ddacurid { get; set; }
        public string? AcctNumber { get; set; }
        public string? Cif { get; set; }
        public string? CustomerName { get; set; }
        public double? CurrencyBalance { get; set; }
        public string? CurrencyCode { get; set; }
        public DateTime? RptDate { get; set; }
    }
}
