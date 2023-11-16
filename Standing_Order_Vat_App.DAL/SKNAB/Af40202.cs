using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Af40202
    {
        public string Userid { get; set; } = null!;
        public short Reportid { get; set; }
        public int DexRowId { get; set; }
    }
}
