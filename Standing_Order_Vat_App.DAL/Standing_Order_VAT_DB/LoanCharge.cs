namespace Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB
{
    public partial class LoanCharge
    {
        public int LoanChargeId { get; set; }
        public string? Branch { get; set; }
        public string? Acct { get; set; }
        public string? Name { get; set; }
        public DateTime? Dateactive { get; set; }
        public double? Totalfees { get; set; }
        public double? Nationalfees { get; set; }
        public double? Vat { get; set; }
    }
}
