namespace Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB
{
    public partial class Testtable
    {
        public int DdascjId { get; set; }
        public string? BranchNumber { get; set; }
        public string? Acct { get; set; }
        public string? CustomerName { get; set; }
        public DateTime? RptDate { get; set; }
        public double? Charged { get; set; }
        public double? Vat { get; set; }
        public double? NationalFees { get; set; }
    }
}
