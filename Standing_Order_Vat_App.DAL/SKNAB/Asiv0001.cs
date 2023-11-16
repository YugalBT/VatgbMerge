using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Asiv0001
    {
        public string Poprctnm { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public decimal? Qtyshppd { get; set; }
        public decimal? Qtyinvcd { get; set; }
        public decimal? Qtyrej { get; set; }
        public decimal? TotalLandedCostAmount { get; set; }
        public decimal? Qtyreserved { get; set; }
        public decimal? Qtyinvreserve { get; set; }
        public decimal? Qtymatch { get; set; }
        public int? DexRowId { get; set; }
    }
}
