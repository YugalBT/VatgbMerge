using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pp900000
    {
        public string Userid { get; set; } = null!;
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public int DexRowId { get; set; }
    }
}
