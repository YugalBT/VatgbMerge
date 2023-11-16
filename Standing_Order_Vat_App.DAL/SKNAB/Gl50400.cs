using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl50400
    {
        public short Periodid { get; set; }
        public short Year1 { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
