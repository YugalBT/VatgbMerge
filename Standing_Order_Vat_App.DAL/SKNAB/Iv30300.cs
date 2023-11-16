using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv30300
    {
        public string Trxsorce { get; set; } = null!;
        public short Doctype { get; set; }
        public string Docnumbr { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public string Hstmodul { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public string Uofm { get; set; } = null!;
        public decimal Trxqty { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Extdcost { get; set; }
        public string Trxloctn { get; set; } = null!;
        public string Trnstloc { get; set; } = null!;
        public short Trfqtyty { get; set; }
        public short Trtqtyty { get; set; }
        public int Ivivindx { get; set; }
        public int Ivivofix { get; set; }
        public short Decplcur { get; set; }
        public short Decplqty { get; set; }
        public decimal Qtybsuom { get; set; }
        public int DexRowId { get; set; }
    }
}
