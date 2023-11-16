using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class ReportInternalName
    {
        public short Prodid { get; set; }
        public short Rptgrind { get; set; }
        public string BusinessDeskReportNam { get; set; } = null!;
        public string Rptgrnms { get; set; } = null!;
        public string InternalReportName { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
