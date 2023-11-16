using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05251
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; } = null!;
        public int Eqpline { get; set; }
        public string Linitmtyp { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public short Qtytype { get; set; }
        public int Sltsqnum { get; set; }
        public string Serltnum { get; set; } = null!;
        public decimal Serltqty { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public decimal Unitcost { get; set; }
        public string Trxsorce { get; set; } = null!;
        public byte Posted { get; set; }
        public short Ovrserlt { get; set; }
        public string Bin { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
