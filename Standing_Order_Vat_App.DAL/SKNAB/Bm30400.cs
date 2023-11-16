using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Bm30400
    {
        public string TrxId { get; set; } = null!;
        public int ComponentId { get; set; }
        public short Sltype { get; set; }
        public int Sltsqnum { get; set; }
        public string Serltnum { get; set; } = null!;
        public decimal Serltqty { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public short Qtytype { get; set; }
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public int Parslseqn { get; set; }
        public int ParentComponentId { get; set; }
        public short Itmtrkop { get; set; }
        public string Trxsorce { get; set; } = null!;
        public decimal Unitcost { get; set; }
        public string Bin { get; set; } = null!;
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public int DexRowId { get; set; }
    }
}
