using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pavw10731
    {
        public string Popivcno { get; set; } = null!;
        public int Ivclinno { get; set; }
        public string Pavidn { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public int Lclinenumber { get; set; }
        public decimal Unitcost { get; set; }
        public string Poprctnm { get; set; } = null!;
        public short Status { get; set; }
        public decimal Qtyinvcd { get; set; }
        public decimal Qtyinvreserve { get; set; }
        public decimal Oruntcst { get; set; }
        public decimal Rcptcost { get; set; }
        public decimal Orcptcost { get; set; }
        public decimal Acpurtot { get; set; }
        public decimal Uppvtotl { get; set; }
        public int Purpvidx { get; set; }
        public decimal Pchrptct { get; set; }
        public decimal Sprcptct { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public decimal Xchgrate { get; set; }
        public short Ratecalc { get; set; }
        public decimal Denxrate { get; set; }
        public byte RevalueInventory { get; set; }
        public decimal Ppvtotal { get; set; }
    }
}
