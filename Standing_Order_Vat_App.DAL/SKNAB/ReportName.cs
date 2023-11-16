using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class ReportName
    {
        public short Prodid { get; set; }
        public string BusinessDeskReportNam { get; set; } = null!;
        public short Rptgrind { get; set; }
        public short Rtpachin { get; set; }
        public decimal Rtgrsbin { get; set; }
        public int DexRowId { get; set; }
    }
}
