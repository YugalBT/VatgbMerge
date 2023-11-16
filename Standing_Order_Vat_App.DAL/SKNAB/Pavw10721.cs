using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pavw10721
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
        public string Ponumber { get; set; } = null!;
        public string Poprctnm { get; set; } = null!;
        public decimal Qtyshppd { get; set; }
        public decimal Qtyinvcd { get; set; }
        public decimal Qtyrej { get; set; }
        public decimal Qtymatch { get; set; }
        public decimal Qtyreserved { get; set; }
        public decimal Qtyinvreserve { get; set; }
        public decimal Umqtyinb { get; set; }
        public decimal Oldcucst { get; set; }
        public string Jobnumbr { get; set; } = null!;
        public string Costcode { get; set; } = null!;
        public short Costtype { get; set; }
        public decimal Orcptcost { get; set; }
        public decimal Ostdcost { get; set; }
        public short Poptype { get; set; }
        public string Trxloctn { get; set; } = null!;
        public DateTime Daterecd { get; set; }
        public int Rctseqnm { get; set; }
        public int Sprctseq { get; set; }
        public decimal Pchrptct { get; set; }
        public decimal Sprcptct { get; set; }
        public decimal Orextcst { get; set; }
        public decimal Ruppvamt { get; set; }
        public int Acpuridx { get; set; }
        public int Invindx { get; set; }
        public int Uppvidx { get; set; }
        public decimal Noteindx { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public decimal Xchgrate { get; set; }
        public short Ratecalc { get; set; }
        public decimal Denxrate { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public byte CapitalItem { get; set; }
        public short ProductIndicator { get; set; }
        public decimal TotalLandedCostAmount { get; set; }
        public short Qtytype { get; set; }
        public decimal PostedLcPpvAmount { get; set; }
    }
}
