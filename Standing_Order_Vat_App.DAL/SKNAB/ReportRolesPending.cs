using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class ReportRolesPending
    {
        public int IdentityColumn { get; set; }
        public string BpGuid { get; set; } = null!;
        public string BpRole { get; set; } = null!;
        public byte Mktoproc { get; set; }
        public string BusinessDeskReportNam { get; set; } = null!;
        public short Prodid { get; set; }
        public string ReportOption { get; set; } = null!;
        public short Rptgrind { get; set; }
        public string UserIdtime { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
