using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop40700
    {
        public string Userid { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public short Decplcur { get; set; }
        public short Decplqty { get; set; }
        public string Uofm { get; set; } = null!;
        public decimal Qtyfrom { get; set; }
        public decimal Qtyto { get; set; }
        public decimal Umqtyinb { get; set; }
        public decimal Unitprce { get; set; }
        public string Curncyid { get; set; } = null!;
        public decimal Oruntprc { get; set; }
        public string Ermsgtxt { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
