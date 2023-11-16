using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv00113
    {
        public string Itemnmbr { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public string Prclevel { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public decimal Toqty { get; set; }
        public short Prictype { get; set; }
        public decimal Prcntage { get; set; }
        public decimal Uomprice { get; set; }
        public short Incordec { get; set; }
        public int DexRowId { get; set; }
    }
}
