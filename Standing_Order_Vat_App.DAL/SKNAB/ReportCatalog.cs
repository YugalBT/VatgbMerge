using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class ReportCatalog
    {
        public string Prodname { get; set; } = null!;
        public string BusinessDeskReportNam { get; set; } = null!;
        public string ReportOption { get; set; } = null!;
        public string BusinessDeskReportTyp { get; set; } = null!;
        public string ReportUrl { get; set; } = null!;
        public DateTime LastDatePublished { get; set; }
        public DateTime LastTimePublished { get; set; }
        public short ReportSeries { get; set; }
        public byte Reviewed { get; set; }
        public int DexRowId { get; set; }
    }
}
