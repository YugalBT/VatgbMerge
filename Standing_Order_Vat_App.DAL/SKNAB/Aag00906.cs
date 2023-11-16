using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00906
    {
        public string Userid { get; set; } = null!;
        public short Wintype { get; set; }
        public short Cmpanyid { get; set; }
        public int AaBudgetId { get; set; }
        public int AaCodeSequence { get; set; }
        public int Actindx { get; set; }
        public int AaActualPriliminary { get; set; }
        public byte Netchng { get; set; }
        public short Year1 { get; set; }
        public short AaRange { get; set; }
        public byte AaAmtQty { get; set; }
        public string Str30 { get; set; } = null!;
        public int AaFromValue { get; set; }
        public int AaToValue { get; set; }
        public int AaRangeType { get; set; }
        public byte AaNodeCode { get; set; }
        public int DexRowId { get; set; }
    }
}
