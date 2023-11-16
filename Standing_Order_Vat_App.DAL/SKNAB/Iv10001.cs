using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv10001
    {
        public string Ivdocnbr { get; set; } = null!;
        public short Ivdoctyp { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public string Uofm { get; set; } = null!;
        public decimal Qtybsuom { get; set; }
        public decimal Trxqty { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Extdcost { get; set; }
        public string Trxloctn { get; set; } = null!;
        public string Trnstloc { get; set; } = null!;
        public short Trfqtyty { get; set; }
        public short Trtqtyty { get; set; }
        public int Ivivindx { get; set; }
        public int Ivivofix { get; set; }
        public byte[] Ivwlnmsg { get; set; } = null!;
        public short Decplcur { get; set; }
        public short Decplqty { get; set; }
        public short Usagetype { get; set; }
        public int DexRowId { get; set; }
    }
}
