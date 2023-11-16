namespace Standing_Order_Vat_App.DAL.CoreData_DB
{
    public partial class AcctHistoryArchive
    {
        public long RecId { get; set; }
        public byte Type { get; set; }
        public string AcctNum { get; set; } = null!;
        public int? TranCode { get; set; }
        public string? TranDate { get; set; }
        public byte? ErrorCode { get; set; }
        public string? TranAmount { get; set; }
        public long? CheckNum { get; set; }
        public byte? TranFlag { get; set; }
        public string? Description { get; set; }
        public long? ImgSeqNum { get; set; }
        public int? ProofSeqNum { get; set; }
        public byte? TranSource { get; set; }
        public string? FloatField1 { get; set; }
        public string? FloatField2 { get; set; }
        public string? FloatField3 { get; set; }
        public byte? FloatDays1 { get; set; }
        public byte? FloatDays2 { get; set; }
        public byte? FloatDays3 { get; set; }
        public string? FcAmount { get; set; }
        public byte? FcType { get; set; }
        public byte? FcCode { get; set; }
        public int? Branch { get; set; }
        public short? Teller { get; set; }
    }
}
