using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00600
    {
        public int AaTreeId { get; set; }
        public string AaTree { get; set; } = null!;
        public short AaLinkType { get; set; }
        public int AaDimId { get; set; }
        public string AaTreeDescr { get; set; } = null!;
        public byte AaTreeMain { get; set; }
        public byte AaTreeInclAllRec { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
