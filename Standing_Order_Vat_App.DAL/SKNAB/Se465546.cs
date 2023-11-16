using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Se465546
    {
        public string Seoptnme { get; set; } = null!;
        public short SeColumnNumber { get; set; }
        public short SeTokenPosition { get; set; }
        public string SeToken { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
