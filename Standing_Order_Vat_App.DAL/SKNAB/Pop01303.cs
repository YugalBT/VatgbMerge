using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop01303
    {
        public string ProjNum { get; set; } = null!;
        public string CostCatId { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public int DexRowId { get; set; }
    }
}
