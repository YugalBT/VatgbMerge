using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Palbsetp
    {
        public short IntegerValue { get; set; }
        public byte AutoOpenSalesDocWindow { get; set; }
        public byte AutoApplyInv { get; set; }
        public int DexRowId { get; set; }
    }
}
