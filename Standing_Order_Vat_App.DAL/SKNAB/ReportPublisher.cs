using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class ReportPublisher
    {
        public string Userid { get; set; } = null!;
        public short Prodid { get; set; }
        public short Rptgrind { get; set; }
        public string BusinessDeskReportNam { get; set; } = null!;
        public string ReportOption { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
