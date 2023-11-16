using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00652
    {
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public string Opttype { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public decimal Unitprce { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Oruntcst { get; set; }
        public decimal Oruntprc { get; set; }
        public int DexRowId { get; set; }
    }
}
