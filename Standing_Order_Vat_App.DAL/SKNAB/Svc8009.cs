using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc8009
    {
        public string Schedid { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public short Freqofpm { get; set; }
        public decimal Quantity { get; set; }
        public string Uofm { get; set; } = null!;
        public short SvcMeterType { get; set; }
        public short SvcPmType { get; set; }
        public string Pmdtlid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
