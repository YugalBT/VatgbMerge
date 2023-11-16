using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa42500
    {
        public short UserField { get; set; }
        public string TableValue { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
