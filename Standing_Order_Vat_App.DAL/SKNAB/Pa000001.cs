using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa000001
    {
        public string Userid { get; set; } = null!;
        public short Wintype { get; set; }
        public string Cntrlnum { get; set; } = null!;
        public short Cntrltyp { get; set; }
        public short Status { get; set; }
        public int DexRowId { get; set; }
    }
}
