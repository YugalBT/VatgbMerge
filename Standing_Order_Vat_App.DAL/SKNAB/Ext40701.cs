using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40701
    {
        public string PtViewId { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public short LinkToProductId { get; set; }
        public string LinkToTable { get; set; } = null!;
        public short Prodid { get; set; }
        public string Tabltech { get; set; } = null!;
        public short ExtenderViewFromType { get; set; }
        public short ExtenderViewTableType { get; set; }
        public int ExtenderFromLine { get; set; }
        public int DexRowId { get; set; }
    }
}
