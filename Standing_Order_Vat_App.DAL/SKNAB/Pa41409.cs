using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa41409
    {
        public string Paptid { get; set; } = null!;
        public string Paequiptid { get; set; } = null!;
        public string Paeqnme { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
