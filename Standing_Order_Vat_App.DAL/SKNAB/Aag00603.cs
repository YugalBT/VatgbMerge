using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00603
    {
        public string Userid { get; set; } = null!;
        public int AaNodeId { get; set; }
        public string AaNode { get; set; } = null!;
        public int AaLevel { get; set; }
        public int AaParentNodeId { get; set; }
        public int AaOrder { get; set; }
        public decimal Noteindx { get; set; }
        public short Status { get; set; }
        public int DexRowId { get; set; }
    }
}
