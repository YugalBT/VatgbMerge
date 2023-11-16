using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00310
    {
        public int AaMlqueryId { get; set; }
        public string AaMlquery { get; set; } = null!;
        public string AaMlqueryDescr { get; set; } = null!;
        public short AaLevelTimeSpread { get; set; }
        public short AaLevelCodeSpread { get; set; }
        public short AaCodeSpreadCol { get; set; }
        public byte AaInclBsaccts { get; set; }
        public byte AaInclPlaccts { get; set; }
        public byte AaInclUnitAccts { get; set; }
        public short AaMatchType { get; set; }
        public string AaCallMacro { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
