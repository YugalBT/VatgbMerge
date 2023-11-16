using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00401v1
    {
        public int? AaTrxDimCodeId { get; set; }
        public int? AaCodeSequence { get; set; }
        public string? AaTrxDimCodeDescr { get; set; }
        public decimal? Prcntage { get; set; }
        public int? DexRowId { get; set; }
    }
}
