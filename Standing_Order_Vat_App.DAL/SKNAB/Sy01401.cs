using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy01401
    {
        public string Userid { get; set; } = null!;
        public short CoDefaultType { get; set; }
        public string Usrdfstr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
