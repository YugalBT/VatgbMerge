namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class DormantListIncomplete
    {
        public int RecordID { get; set; }
        public DateTime DateRequested { get; set; }
        public string Acct_Number { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Particulars { get; set; }
        
        public string Initial_Id_Employee { get; set; }
        public string? Reactivate_Id_Employee { get; set; }
        public DateTime? DatePerformed { get; set; }
        public string? EntryStatusDescription { get; set; }
        public string? AcctType { get; set; }
        
        public string? AcctStatus { get; set; }
        public string? CoreBranchNumber { get; set; }
        public string? IssuingDepartment { get; set; }
        public string initName { get; set; }
        public string Branch { get; set; }


    }
}