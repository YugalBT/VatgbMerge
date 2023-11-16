using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00317
    {
        public string Userid { get; set; } = null!;
        public int AaTrxDimCodeId { get; set; }
        public int DexRowId { get; set; }
        public string AaUdfcodeString { get; set; } = null!;
    }
}
