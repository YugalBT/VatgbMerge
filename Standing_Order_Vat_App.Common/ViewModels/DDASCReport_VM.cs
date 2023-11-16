namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class DDASCReport_VM
    {
        public int DDASCJ_ID { get; set; }
        public string? Branch_number { get; set; }
        public string? ACCT { get; set; }
        public string? Customer_Name { get; set; }
        public DateTime? RptDate { get; set; }
        public string? Charged { get; set; }
        public string? VAT { get; set; }
        public string? National_Fees { get; set; } 
        public ulong TotalRecordCount { get; set; } = 0;


        //public string dwnloadcharged { get; set; }
        //public string dwnloadVAT { get; set; }
        //public string dwnloadNational_Fees { get; set; }
    }
    public class DDASCReport_VM_Download
    {
        public int DDASCJ_ID { get; set; }
        public string? Branch_number { get; set; }
        public string? ACCT { get; set; }
        public string? Customer_Name { get; set; }
        public string RptDate { get; set; }
        public string? Charged { get; set; }
        public string? VAT { get; set; }
        public string? National_Fees { get; set; }

    }
}
