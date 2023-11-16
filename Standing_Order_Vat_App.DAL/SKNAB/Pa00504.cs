using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa00504
    {
        public string Custnmbr { get; set; } = null!;
        public string Pacustalias { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
