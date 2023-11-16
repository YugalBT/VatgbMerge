namespace Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB
{
    public partial class SafeKeepingPayment
    {
        public int SafeKeepingId { get; set; }
        public string? Cif { get; set; }
        public string? Acct { get; set; }
        public DateTime? Dateactive { get; set; }
        public string? Branch { get; set; }
        public string? Transcode { get; set; }
        public string? ProofSequence { get; set; }
        public string? CheckNumber { get; set; }
        public double? Transamt { get; set; }
        public double? NationalFees { get; set; }
        public double? Vat { get; set; }
    }
}
