using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06201
    {
        public string Servicebom { get; set; } = null!;
        public decimal Sequence1 { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public decimal Quantity { get; set; }
        public DateTime Effdate { get; set; }
        public DateTime Expndate { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
