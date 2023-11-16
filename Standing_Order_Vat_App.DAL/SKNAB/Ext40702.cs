using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40702
    {
        public string PtViewId { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Fieldnam { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
