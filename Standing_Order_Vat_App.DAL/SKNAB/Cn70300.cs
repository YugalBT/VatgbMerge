using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn70300
    {
        public short CnReportName { get; set; }
        public string CnReportOption { get; set; } = null!;
        public byte Detldrpt { get; set; }
        public string QueryId { get; set; } = null!;
        public string CollectorId { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public byte CnPrintFullNote { get; set; }
        public short CnNoteStatus { get; set; }
        public byte CnIncludeNoneAction { get; set; }
        public byte CnIncludePromiseActio { get; set; }
        public byte CnIncludeDisputeActio { get; set; }
        public byte CnIncludeSpecialActio { get; set; }
        public short CnReportAllOrCollect { get; set; }
        public short CnReportAllOrQuery { get; set; }
        public byte Askechtm { get; set; }
        public byte Prtoscrn { get; set; }
        public byte Prtoprtr { get; set; }
        public byte Prntofil { get; set; }
        public string FileName { get; set; } = null!;
        public short Expttype { get; set; }
        public short Iffilxst { get; set; }
        public int DexRowId { get; set; }
    }
}
