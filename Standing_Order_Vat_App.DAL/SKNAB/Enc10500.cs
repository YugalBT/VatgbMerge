using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Enc10500
    {
        public string Ponumber { get; set; } = null!;
        public int Polnenum { get; set; }
        public short Poptype { get; set; }
        public string Poprctnm { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public short Status { get; set; }
        public DateTime Glpostdt { get; set; }
        public DateTime Trxdate { get; set; }
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public decimal Qtyshppd { get; set; }
        public decimal Qtyinvcd { get; set; }
        public decimal Qtyreserved { get; set; }
        public int Invindx { get; set; }
        public string Uofm { get; set; } = null!;
        public short Umdpqtys { get; set; }
        public decimal Umqtyinb { get; set; }
        public decimal Orextcst { get; set; }
        public decimal Liqudamt { get; set; }
        public DateTime Reqdate { get; set; }
        public int AaDimId { get; set; }
        public int AaTrxDimId { get; set; }
        public int DexRowId { get; set; }
    }
}
