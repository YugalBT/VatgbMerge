using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop30000
    {
        public string Bachnumb { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public DateTime Glpostdt { get; set; }
        public int DexRowId { get; set; }
    }
}
