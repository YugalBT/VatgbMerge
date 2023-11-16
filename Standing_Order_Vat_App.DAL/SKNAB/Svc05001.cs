using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05001
    {
        public short ReturnRecordType { get; set; }
        public string Retdocid { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public string Linitmtyp { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public string Serlnmbr { get; set; } = null!;
        public decimal Quantity { get; set; }
        public byte Received { get; set; }
        public byte Shipped { get; set; }
        public int DexRowId { get; set; }
    }
}
