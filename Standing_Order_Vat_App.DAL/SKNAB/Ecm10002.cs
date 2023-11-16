using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ecm10002
    {
        public string Ponumber { get; set; } = null!;
        public int Ord { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public string Vnditnum { get; set; } = null!;
        public string Vnditdsc { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
