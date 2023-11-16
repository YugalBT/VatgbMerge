using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv10201
    {
        public string Itemnmbr { get; set; } = null!;
        public string Trxloctn { get; set; } = null!;
        public short Qtytype { get; set; }
        public DateTime Docdate { get; set; }
        public int Rctseqnm { get; set; }
        public short Origindoctype { get; set; }
        public string Origindocid { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public int Cmpntseq { get; set; }
        public decimal Qtysold { get; set; }
        public decimal Unitcost { get; set; }
        public int Ivivindx { get; set; }
        public int Ivivofix { get; set; }
        public int Srcrctseqnm { get; set; }
        public short Trxreference { get; set; }
        public short Pchsrcty { get; set; }
        public int DexRowId { get; set; }
    }
}
