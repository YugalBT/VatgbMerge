using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl50102
    {
        public int Jrnentry { get; set; }
        public string Trxsorce { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Rvtrxsrc { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
