using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00920
    {
        public string Srvtype { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Labitmst { get; set; } = null!;
        public string Labitmov { get; set; } = null!;
        public string Labitmdb { get; set; } = null!;
        public string HotlineLaborItem { get; set; } = null!;
        public string TravelLaborItem { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public byte Pmflag { get; set; }
        public byte Contflag { get; set; }
        public string SvcServiceBatchId { get; set; } = null!;
        public string SvcServiceDocumentId { get; set; } = null!;
        public byte SvcSalesOnly { get; set; }
        public string SvcSCreditBatchId { get; set; } = null!;
        public string SvcSCreditDocumentId { get; set; } = null!;
        public string SvcZeroBatchId { get; set; } = null!;
        public string SvcZeroDocumentId { get; set; } = null!;
        public string SvcMinimumLabor { get; set; } = null!;
        public string SvcMinimumTravel { get; set; } = null!;
        public string SvcMinimumHotline { get; set; } = null!;
        public string SvcRoundedLabor { get; set; } = null!;
        public string SvcRoundedTravel { get; set; } = null!;
        public string SvcRoundedHotline { get; set; } = null!;
        public int SvcSalesIndexPart { get; set; }
        public int SvcSalesIndexLabor { get; set; }
        public int SvcSalesIndexMisc { get; set; }
        public int SvcSalesIndexExpense { get; set; }
        public int SvcCogsIndexPart { get; set; }
        public int SvcCogsIndexLabor { get; set; }
        public int SvcCogsIndexMisc { get; set; }
        public int SvcCogsIndexExpense { get; set; }
        public int SvcSalesReturnIndex { get; set; }
        public int DexRowId { get; set; }
    }
}
