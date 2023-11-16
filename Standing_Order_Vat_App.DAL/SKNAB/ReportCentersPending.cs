using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class ReportCentersPending
    {
        public int IdentityColumn { get; set; }
        public string BpreportCenter { get; set; } = null!;
        public byte Mktoproc { get; set; }
        public short Rptgrind { get; set; }
        public short Prodid { get; set; }
        public string BusinessDeskReportNam { get; set; } = null!;
        public string ReportOption { get; set; } = null!;
        public string UserIdtime { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
