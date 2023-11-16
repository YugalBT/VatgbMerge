using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv00117
    {
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public short Priority { get; set; }
        public string Bin { get; set; } = null!;
        public decimal Minstockqty { get; set; }
        public decimal Maxstockqty { get; set; }
        public int DexRowId { get; set; }
    }
}
