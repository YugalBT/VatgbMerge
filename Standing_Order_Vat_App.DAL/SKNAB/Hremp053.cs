using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hremp053
    {
        public string EmpidI { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string ZipcodeI { get; set; } = null!;
        public string County { get; set; } = null!;
        public string Country { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
