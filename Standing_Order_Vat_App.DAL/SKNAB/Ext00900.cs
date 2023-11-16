using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext00900
    {
        public string ExtenderLookupId { get; set; } = null!;
        public string Str30 { get; set; } = null!;
        public string UdFormFieldDesc { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
