using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc07511
    {
        public string Techid { get; set; } = null!;
        public string SvcFormId { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public decimal Quantity { get; set; }
        public DateTime Date1 { get; set; }
        public string WorkType { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public decimal Unitprce { get; set; }
        public decimal Amtbilld { get; set; }
        public byte SvcReceipt { get; set; }
        public string Callnbr { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public int DexRowId { get; set; }
        public string Txtfield { get; set; } = null!;
    }
}
