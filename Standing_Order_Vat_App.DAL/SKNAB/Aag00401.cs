using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00401
    {
        public int AaTrxDimId { get; set; }
        public int AaTrxDimCodeId { get; set; }
        public string AaTrxDimCode { get; set; } = null!;
        public string AaTrxDimCodeDescr { get; set; } = null!;
        public string AaTrxDimCodeDescr2 { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public byte Inactive { get; set; }
        public int DexRowId { get; set; }
    }
}
