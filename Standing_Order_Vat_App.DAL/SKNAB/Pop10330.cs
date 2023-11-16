using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop10330
    {
        public short Itmtrkop { get; set; }
        public string Poprctnm { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public int Sltsqnum { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Serltnum { get; set; } = null!;
        public decimal Serltqty { get; set; }
        public string Trxsorce { get; set; } = null!;
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public decimal Unitcost { get; set; }
        public short Qtytype { get; set; }
        public string Bin { get; set; } = null!;
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public int DexRowId { get; set; }
    }
}
