using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa10721
    {
        public string Papurordnum { get; set; } = null!;
        public int Polnenum { get; set; }
        public string Pavidn { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public string Vendorid { get; set; } = null!;
        public short Status { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public short Appytype { get; set; }
        public decimal Extdcost { get; set; }
        public decimal Oruntcst { get; set; }
        public string Pacostcatid { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public decimal Rcptcost { get; set; }
        public decimal Unitcost { get; set; }
        public int DexRowId { get; set; }
    }
}
