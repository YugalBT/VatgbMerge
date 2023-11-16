using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00300
    {
        public int AaDistrQueryId { get; set; }
        public string AaDistrQuery { get; set; } = null!;
        public string AaDistrQueryDescr { get; set; } = null!;
        public byte AaInclBsaccts { get; set; }
        public byte AaInclPlaccts { get; set; }
        public byte AaInclUnitAccts { get; set; }
        public string AaCallMacro { get; set; } = null!;
        public short AaMatchType { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
