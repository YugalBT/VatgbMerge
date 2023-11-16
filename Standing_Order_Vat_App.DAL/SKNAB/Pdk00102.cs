using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pdk00102
    {
        public string Employid { get; set; } = null!;
        public string PdkDelegate { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
