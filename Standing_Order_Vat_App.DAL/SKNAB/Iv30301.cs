using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv30301
    {
        public short Doctype { get; set; }
        public string Docnumbr { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public short Dtlseqnm { get; set; }
        public short Qtytype { get; set; }
        public string Rcptnmbr { get; set; } = null!;
        public decimal Rcptqty { get; set; }
        public decimal Rcptexct { get; set; }
        public int DexRowId { get; set; }
    }
}
