using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Edcml002
    {
        public string Curncyid { get; set; } = null!;
        public string Crncydsc { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
