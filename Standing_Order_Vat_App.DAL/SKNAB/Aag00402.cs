using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00402
    {
        public int AaTrxDimId { get; set; }
        public int AaTrxDimCodeNumId { get; set; }
        public decimal AaTrxDimCodeNum { get; set; }
        public int DexRowId { get; set; }
    }
}
