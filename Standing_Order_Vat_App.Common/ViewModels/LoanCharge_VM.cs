namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class LoanCharge_VM
    {
        public int LoanChargeId { get; set; }
        public string? Branch { get; set; }
        public string? Acct { get; set; }
        public string? Name { get; set; }
        public DateTime? Dateactive { get; set; }
        public string Totalfees { get; set; }
        public string Nationalfees { get; set; }
        public string Vat { get; set; }
        public ulong TotalRecordCount { get; set; } = 0;

    }
    public class LoanCharge_VM_Download
    {
        public int LoanChargeId { get; set; }
        public string? Branch { get; set; }
        public string? Acct { get; set; }
        public string? Name { get; set; }
        public string Dateactive { get; set; }
        public string Totalfees { get; set; }
        public string Nationalfees { get; set; }
        public double? Vat { get; set; }

    }
}
