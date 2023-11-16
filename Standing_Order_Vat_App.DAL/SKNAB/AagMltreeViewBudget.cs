using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class AagMltreeViewBudget
    {
        public int AaTreeId { get; set; }
        public string AaTree { get; set; } = null!;
        public int AaDimId { get; set; }
        public int AaLevel { get; set; }
        public int AaNodeId { get; set; }
        public int AaMstrId { get; set; }
    }
}
