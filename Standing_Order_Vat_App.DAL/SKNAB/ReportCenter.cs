using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class ReportCenter
    {
        public string BusinessDeskReportNam { get; set; } = null!;
        public string ReportOption { get; set; } = null!;
        public string Prodname { get; set; } = null!;
        public string BpreportCenter { get; set; } = null!;
        public byte Mktoproc { get; set; }
        public int DexRowId { get; set; }
    }
}
