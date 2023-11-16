using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me123505
    {
        public string Mebankid { get; set; } = null!;
        public string Mebankdesc { get; set; } = null!;
        public string OutputFormat { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
