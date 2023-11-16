using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00902
    {
        public int AaBudgetTreeId { get; set; }
        public int AaTrxDimCodeId { get; set; }
        public int AaTrxDimParCodeId { get; set; }
        public int AaCodeSequence { get; set; }
        public int AaLevel { get; set; }
        public string AaLvlCodeString { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
