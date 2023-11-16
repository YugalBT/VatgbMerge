using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv30302
    {
        public string Docnumbr { get; set; } = null!;
        public short Doctype { get; set; }
        public decimal Lnseqnbr { get; set; }
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Bin { get; set; } = null!;
        public string Tobin { get; set; } = null!;
        public short Qtytype { get; set; }
        public decimal Qtyslctd { get; set; }
        public int DexRowId { get; set; }
    }
}
