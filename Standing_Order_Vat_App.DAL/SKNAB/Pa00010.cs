using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa00010
    {
        public string Custnmbr { get; set; } = null!;
        public string Bankname { get; set; } = null!;
        public string Bnkbrnch { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
