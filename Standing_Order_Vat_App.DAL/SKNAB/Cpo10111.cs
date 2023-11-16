using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cpo10111
    {
        public string Ponumber { get; set; } = null!;
        public int Ord { get; set; }
        public int Actindx { get; set; }
        public decimal CommittedAmount { get; set; }
        public int DexRowId { get; set; }
    }
}
