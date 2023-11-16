using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv00300
    {
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public string Lotnumbr { get; set; } = null!;
        public decimal Qtyrecvd { get; set; }
        public decimal Qtysold { get; set; }
        public decimal Atyalloc { get; set; }
        public decimal Unitcost { get; set; }
        public int Rctseqnm { get; set; }
        public string Vndrnmbr { get; set; } = null!;
        public byte Ltnumsld { get; set; }
        public short Qtytype { get; set; }
        public string Bin { get; set; } = null!;
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public int DexRowId { get; set; }
    }
}
