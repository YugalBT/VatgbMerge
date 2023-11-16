using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv10003
    {
        public string Ivdocnbr { get; set; } = null!;
        public short Ivdoctyp { get; set; }
        public decimal Lnseqnbr { get; set; }
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Bin { get; set; } = null!;
        public string Tobin { get; set; } = null!;
        public short Qtytype { get; set; }
        public decimal Quantity { get; set; }
        public decimal Qtyscrapped { get; set; }
        public int DexRowId { get; set; }
    }
}
