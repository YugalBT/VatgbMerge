using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40703
    {
        public string PtViewId { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public decimal Lnseqnbr { get; set; }
        public string Fieldnam { get; set; } = null!;
        public string FieldName2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
