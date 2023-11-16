using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class ReportCatalogPending
    {
        public string BusinessDeskReportNam { get; set; } = null!;
        public string ReportOption { get; set; } = null!;
        public DateTime LastDatePublished { get; set; }
        public string Dscriptn { get; set; } = null!;
        public byte Mkdtopst { get; set; }
        public int IdentityColumn { get; set; }
        public string Prodname { get; set; } = null!;
        public int ListviewIndex { get; set; }
        public short Rptgrind { get; set; }
        public short Prodid { get; set; }
        public string UserIdtime { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
