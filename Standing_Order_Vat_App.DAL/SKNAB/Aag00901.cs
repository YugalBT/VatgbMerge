using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00901
    {
        public int AaBudgetTreeId { get; set; }
        public int AaTrxDimId { get; set; }
        public int AaOrder { get; set; }
        public short AaSelectOpt { get; set; }
        public string AaTrxDimCodeFr { get; set; } = null!;
        public string AaTrxDimCodeTo { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
