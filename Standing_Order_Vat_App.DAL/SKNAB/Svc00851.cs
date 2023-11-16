using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00851
    {
        public string EcoNumber { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public short Rcrdtype { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public decimal Quantity { get; set; }
        public string Uofm { get; set; } = null!;
        public string Uomschdl { get; set; } = null!;
        public decimal Unitcost { get; set; }
        public decimal Unitprce { get; set; }
        public decimal Extdcost { get; set; }
        public decimal Xtndprce { get; set; }
        public int DexRowId { get; set; }
    }
}
