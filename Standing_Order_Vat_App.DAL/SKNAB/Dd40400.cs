using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Dd40400
    {
        public short Cmpanyid { get; set; }
        public string Dddesc10 { get; set; } = null!;
        public short Index1 { get; set; }
        public string Ddline { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
