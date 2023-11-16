using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cpo40002
    {
        public short Cmpanyid { get; set; }
        public string Budgetid { get; set; } = null!;
        public short Year1 { get; set; }
        public int DexRowId { get; set; }
    }
}
