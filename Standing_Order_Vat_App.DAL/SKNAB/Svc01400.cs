using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc01400
    {
        public string Userid { get; set; } = null!;
        public string CallFrom { get; set; } = null!;
        public string CallTo { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
