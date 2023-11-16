using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc8001
    {
        public string Pmdtlid { get; set; } = null!;
        public short Rcrdtype { get; set; }
        public decimal Lnseqnbr { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public decimal Quantity { get; set; }
        public string Uofm { get; set; } = null!;
        public decimal Unitprce { get; set; }
        public decimal Xtndprce { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Extdcost { get; set; }
        public int DexRowId { get; set; }
    }
}
