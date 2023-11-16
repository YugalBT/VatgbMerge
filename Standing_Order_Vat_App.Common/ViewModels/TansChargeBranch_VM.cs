﻿namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class TansChargeBranch_VM
    {
        public int TransferChargeId { get; set; }
        public string? Cif { get; set; }
        public string? Acct { get; set; }
        public DateTime? Dateactive { get; set; }
        public string? Branch { get; set; }
        public string? Trasncode { get; set; }
        public string? ProffSequence { get; set; }
        public string? CheckNumber { get; set; }
        public string? TransAmt { get; set; }
        public double? NationalFees { get; set; }
        public string? Vat { get; set; }
        public ulong TotalRecordCount { get; set; } = 0;
    }
    public class TansChargeBranch_VM_Download
    {
        public int TransferChargeId { get; set; }
        public string? Cif { get; set; }
        public string? Acct { get; set; }
        public string Dateactive { get; set; }
        public string? Branch { get; set; }
        public string? Trasncode { get; set; }
        public string? ProffSequence { get; set; }
        public string? CheckNumber { get; set; }
        public string? TransAmt { get; set; }
        public double? NationalFees { get; set; }
        public string? Vat { get; set; }
    }
}
