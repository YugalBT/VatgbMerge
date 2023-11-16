using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv00500
    {
        public short Decplqty { get; set; }
        public string Itmclscd { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public short Itemtype { get; set; }
        public string? Baseuofm { get; set; }
        public string Itmshnam { get; set; } = null!;
        public string Itmgedsc { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public decimal? Qtyavail { get; set; }
        public string Uscatvls1 { get; set; } = null!;
        public string Uscatvls2 { get; set; } = null!;
        public string Uscatvls3 { get; set; } = null!;
        public string Uscatvls4 { get; set; } = null!;
        public string Uscatvls5 { get; set; } = null!;
        public string Uscatvls6 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
