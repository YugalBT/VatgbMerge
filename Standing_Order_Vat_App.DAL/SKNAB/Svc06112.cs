using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06112
    {
        public short Worectype { get; set; }
        public string Workordnum { get; set; } = null!;
        public string Linitmtyp { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Bin { get; set; } = null!;
        public short Qtytype { get; set; }
        public decimal Quantity { get; set; }
        public byte Posted { get; set; }
        public byte Mkdtopst { get; set; }
        public int DexRowId { get; set; }
    }
}
