using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Tx00101
    {
        public string Taxschid { get; set; } = null!;
        public string Txschdsc { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
