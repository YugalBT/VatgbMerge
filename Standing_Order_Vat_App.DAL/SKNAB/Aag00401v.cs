using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00401v
    {
        public int AaTrxDimId { get; set; }
        public int AaTrxDimCodeId { get; set; }
        public string? AaNode { get; set; }
        public int DexRowId { get; set; }
    }
}
