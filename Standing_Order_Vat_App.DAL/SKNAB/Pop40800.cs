using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop40800
    {
        public string Locncode { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
