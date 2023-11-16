using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00405
    {
        public int AaTrxDimId { get; set; }
        public int AaRelTrxDimId { get; set; }
        public short AaTrxDimRelType { get; set; }
        public int DexRowId { get; set; }
    }
}
