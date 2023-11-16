namespace Standing_Order_Vat_App.DAL.CoreData_DB
{
    public partial class AcctHistoryStage
    {
        public long RecId { get; set; }
        public string Type { get; set; } = null!;
        public string AcctNum { get; set; } = null!;
        public string? TranCode { get; set; }
        public string? TranDate { get; set; }
        public string? ErrorCode { get; set; }
        public string? TranAmount { get; set; }
        public string? CheckNum { get; set; }
        public string? TranFlag { get; set; }
        public string? Description { get; set; }
        public string? ImgSeqNum { get; set; }
        public string? ProofSeqNum { get; set; }
        public string? TranSource { get; set; }
        public string? FloatField1 { get; set; }
        public string? FloatField2 { get; set; }
        public string? FloatField3 { get; set; }
        public string? FloatDays1 { get; set; }
        public string? FloatDays2 { get; set; }
        public string? FloatDays3 { get; set; }
        public string? FcAmount { get; set; }
        public string? FcType { get; set; }
        public string? FcCode { get; set; }
        public string? Branch { get; set; }
        public string? Teller { get; set; }
    }
}
