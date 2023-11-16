using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pdk01601
    {
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public string PdkBillingNoteId { get; set; } = null!;
        public int DexRowId { get; set; }
        public string Patx500 { get; set; } = null!;
    }
}
