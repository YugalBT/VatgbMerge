using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00400
    {
        public string Confgref { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string RevLevel { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
