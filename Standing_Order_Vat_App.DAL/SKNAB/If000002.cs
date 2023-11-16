using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class If000002
    {
        public string Sgmntid { get; set; } = null!;
        public int IfFundAccountIndex { get; set; }
        public int IfCfctAccountIndex { get; set; }
        public string Actdescr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
