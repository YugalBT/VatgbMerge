namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class CustomerSummary_VM
    {
        public int Report { get; set; }
        public DateTime Startdate { get; set; } = DateTime.Now;
        public DateTime Enddate { get; set; } = DateTime.Now;
        public string search { get; set; }
        public virtual string? Customersacc { get; set; }
        public virtual List<Customer_VM>? Customers { get; set; }
        public virtual List<StandingOrder_VM>? StandingOrder { get; set; }
        public virtual List<UserRole_VM> UserRole_VMs { get; set; }
        public virtual List<DDASCReport_VM> DDASCReport_VMs { get; set; }
        public virtual List<LoanCharge_VM> LoanCharge_VMs { get; set; }
        public virtual List<StopPayCharge_VM> StopPayCharge_VMs { get; set; }
        public virtual List<TansChargeBranch_VM> TansChargeBranch_VMs { get; set; }
        public virtual List<SafekeepingPayment_VM> SafekeepingPayment_VMs { get; set; }
        public bool isvalue { get; set; }
        public int acct { get; set; }

    }
}
