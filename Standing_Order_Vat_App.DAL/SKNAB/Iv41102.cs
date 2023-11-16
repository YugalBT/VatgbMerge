using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv41102
    {
        public string LandedCostGroupId { get; set; } = null!;
        public string LandedCostId { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
