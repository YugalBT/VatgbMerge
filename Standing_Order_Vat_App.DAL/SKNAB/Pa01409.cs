using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01409
    {
        public string Paprojnumber { get; set; } = null!;
        public string Paequiptid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
