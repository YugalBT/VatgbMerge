using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa41302
    {
        public string Paprojnumber { get; set; } = null!;
        public short Sgmtnumb { get; set; }
        public string Sgmtname { get; set; } = null!;
        public string Sgmntid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
