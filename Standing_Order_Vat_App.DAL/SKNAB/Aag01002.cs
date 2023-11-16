using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag01002
    {
        public int AaTrxDimId { get; set; }
        public int AaTrxDimCodeId { get; set; }
        public int AaUdfid { get; set; }
        public string AaUdftext { get; set; } = null!;
        public DateTime AaUdfdate { get; set; }
        public decimal AaUdfnumeric { get; set; }
        public byte AaUdfboolean { get; set; }
        public int DexRowId { get; set; }
    }
}
