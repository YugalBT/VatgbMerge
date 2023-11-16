using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa42801
    {
        public string Custclas { get; set; } = null!;
        public string Pabillcycleid { get; set; } = null!;
        public string Pabillformat { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
