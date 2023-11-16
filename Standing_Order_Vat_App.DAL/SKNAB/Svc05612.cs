using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05612
    {
        public string RtvNumber { get; set; } = null!;
        public decimal RtvLine { get; set; }
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Loccodeb { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Bin { get; set; } = null!;
        public string Tobin { get; set; } = null!;
        public short Qtytype { get; set; }
        public decimal Quantity { get; set; }
        public byte Posted { get; set; }
        public int DexRowId { get; set; }
    }
}
