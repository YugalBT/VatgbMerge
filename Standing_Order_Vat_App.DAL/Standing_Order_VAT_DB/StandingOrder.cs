namespace Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB
{
    public partial class StandingOrder
    {
        public int Snid { get; set; }
        public string? BranchNumber { get; set; }
        public string? SequenceNumber { get; set; }
        public string? Acct { get; set; }
        public string? TrCd { get; set; }
        public string? Name { get; set; }
        public double? TotalTransactionAmt { get; set; }
        public DateTime? DateActive { get; set; }
        public string? SuspenseDescr { get; set; }
        public string? SusTc { get; set; }
        public string? OffsetAcctNumber { get; set; }
        public double? TransactionAmt { get; set; }
        public double? NationalFees { get; set; }
        public double? TotalFees { get; set; }
        public double? Vat { get; set; }
    }
}
