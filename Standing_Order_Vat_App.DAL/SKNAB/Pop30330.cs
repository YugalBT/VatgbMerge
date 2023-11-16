using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop30330
    {
        public string Poprctnm { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public int Sltsqnum { get; set; }
        public string Serltnum { get; set; } = null!;
        public decimal Serltqty { get; set; }
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public decimal Unitcost { get; set; }
        public string Trxsorce { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public short Qtytype { get; set; }
        public string Bin { get; set; } = null!;
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public int DexRowId { get; set; }
    }
}
