using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00225
    {
        public string Itemnmbr { get; set; } = null!;
        public string Prdline { get; set; } = null!;
        public string Probcde { get; set; } = null!;
        public string Rprcode { get; set; } = null!;
        public int Numoftrx { get; set; }
        public int DexRowId { get; set; }
    }
}
