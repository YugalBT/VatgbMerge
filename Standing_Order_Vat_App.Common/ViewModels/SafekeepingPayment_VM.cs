namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class SafekeepingPayment_VM
    {
        public int SafeKeepingId { get; set; }
        public string? Cif { get; set; } 
        public string? Acct { get; set; } 
        public DateTime? Dateactive { get; set; }
        public string? Branch { get; set; } 
        public string? Transcode { get; set; }
        public string? ProofSequence { get; set; }
        public string? CheckNumber { get; set; }
        public string? Transamt { get; set; }
        public string? NationalFees { get; set; }
        public string? Vat { get; set; }
        public ulong TotalRecordCount { get; set; } = 0;
    }
    public class SafekeepingPayment_VM_Download
    {
        public int SafeKeepingId { get; set; }
        public string? Cif { get; set; } 
        public string? Acct { get; set; } 
        public string Dateactive { get; set; }
        public string? Branch { get; set; } 
        public string? Transcode { get; set; }
        public string? ProofSequence { get; set; }
        public string? CheckNumber { get; set; }
        public string? Transamt { get; set; }
        public double? NationalFees { get; set; }
        public string? Vat { get; set; }
        public ulong TotalRecordCount { get; set; } = 0;
    }
}
