using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa60030
    {
        public string Paptid { get; set; } = null!;
        public string Pabillcycleid1 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
