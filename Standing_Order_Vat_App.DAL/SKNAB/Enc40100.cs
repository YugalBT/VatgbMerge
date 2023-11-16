using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Enc40100
    {
        public short Cmpanyid { get; set; }
        public string Budgetid { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public short Year1 { get; set; }
        public int DexRowId { get; set; }
    }
}
