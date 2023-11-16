using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm40102
    {
        public string Uniqkey { get; set; } = null!;
        public int Nxtrnnmbr { get; set; }
        public int DexRowId { get; set; }
    }
}
