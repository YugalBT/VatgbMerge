using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc30701
    {
        public string Orddocid { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public short Status { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public decimal Trnsfqty { get; set; }
        public decimal Qtyfulfi { get; set; }
        public decimal Qtyshppd { get; set; }
        public decimal QtyToReceive { get; set; }
        public decimal Qtyrecvd { get; set; }
        public string Callnbr { get; set; } = null!;
        public short Srvrectype { get; set; }
        public int Servlitemseq { get; set; }
        public int Eqpline { get; set; }
        public string Linitmtyp { get; set; } = null!;
        public string Retdocid { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public string RtvNumber { get; set; } = null!;
        public short Worectype { get; set; }
        public string Workordnum { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
