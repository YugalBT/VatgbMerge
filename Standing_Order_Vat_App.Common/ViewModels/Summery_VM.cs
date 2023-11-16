namespace Standing_Order_Vat_App.Common.ViewModels
{

    public class Summery_VM
    {

        public int Report { get; set; }
        public DateTime dateFrom { get; set; } = DateTime.Now;
        public DateTime DateTo { get; set; } = DateTime.Now;
        public string? RoleType { get; set; }
        public int Branch { get; set; }
        public virtual List<StandingOrder_VM>? StandingOrder { get; set; }
        public virtual List<UserRole_VM>? UserRole_VMs { get; set; }
        public virtual List<DDASCReport_VM>? DDASCReport_VMs { get; set; }
        public virtual List<LoanCharge_VM>? LoanCharge_VMs { get; set; }
        public virtual List<StopPayCharge_VM>? StopPayCharge_VMs { get; set; }
        public virtual List<TansChargeBranch_VM>? TansChargeBranch_VMs { get; set; }
        public virtual List<SafekeepingPayment_VM>? SafekeepingPayment_VMs { get; set; }
        public virtual List<VATOnFraudCharge_VM>? VATOnFraudChargeVMs { get; set; }
        public virtual List<VATOnTransactionCharge_VM>? VATOnTransacactionVMs { get; set; }
        public bool isvalue { get; set; }
        public string search { get; set; }
    }
}
