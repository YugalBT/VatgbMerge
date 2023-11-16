using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv00105
    {
        public string Itemnmbr { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public short Decplcur { get; set; }
        public decimal Listprce { get; set; }
        public int DexRowId { get; set; }
    }
}
