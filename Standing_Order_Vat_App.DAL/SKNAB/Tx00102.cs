using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Tx00102
    {
        public string Taxschid { get; set; } = null!;
        public string Taxdtlid { get; set; } = null!;
        public short Txdtlbse { get; set; }
        public byte Tdtaxtax { get; set; }
        public byte AutoCalculate { get; set; }
        public int DexRowId { get; set; }
    }
}
