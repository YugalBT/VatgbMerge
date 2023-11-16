using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cfm40100
    {
        public string Vendorid { get; set; } = null!;
        public string Ponumber { get; set; } = null!;
        public short Postatus { get; set; }
        public DateTime Docdate { get; set; }
        public string Pymtrmid { get; set; } = null!;
        public int? Disgrper { get; set; }
        public int? Duegrper { get; set; }
        public decimal? Amount { get; set; }
        public int? DexRowId { get; set; }
    }
}
