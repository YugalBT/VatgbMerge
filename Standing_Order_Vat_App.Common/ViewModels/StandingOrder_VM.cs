namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class StandingOrder_VM
    {

        public string? BranchNumber { get; set; }
        public DateTime? DateActive { get; set; }
        public string? Acct { get; set; }
        public string? OffsetAcctNumber { get; set; }
        public string? TotalFees { get; set; }
        public string? NationalFees { get; set; }
        public string? Vat { get; set; }
        public ulong TotalRecordCount { get; set; } = 0;
    }

    public class StandingOrder_VM_Download
    {

        public string? BranchNumber { get; set; }
        public string? DateActive { get; set; }
        public string? Acct { get; set; }
        public string? OffsetAcctNumber { get; set; }
        public string? TotalFees { get; set; }
        public string? NationalFees { get; set; }
        public string? Vat { get; set; }
        public string? CustomerName { get; set; }
    
    }
}
