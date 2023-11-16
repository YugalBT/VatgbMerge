namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public partial class Audit
    {
        public int AuditId { get; set; }
        public string AuditUser { get; set; } = null!;
        public string AuditApplication { get; set; } = null!;
        public string AuditTable { get; set; } = null!;
        public int AuditTableRow { get; set; }
        public string AuditField { get; set; } = null!;
        public string AuditAction { get; set; } = null!;
        public string? AuditOldVal { get; set; }
        public string? AuditNewVal { get; set; }
        public DateTime AuditTimestamp { get; set; }
        public string AuditWorkstation { get; set; } = null!;
    }
}
