using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00910
    {
        public string Svcarea { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
