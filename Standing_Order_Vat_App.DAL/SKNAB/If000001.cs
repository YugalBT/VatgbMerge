using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class If000001
    {
        public string Uniqkey { get; set; } = null!;
        public byte IfActivated { get; set; }
        public byte IfDistributionCreated { get; set; }
        public short IfMethod { get; set; }
        public short Sgmtnumb { get; set; }
        public string Sgmntid { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
