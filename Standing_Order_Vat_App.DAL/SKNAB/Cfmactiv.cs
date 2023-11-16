using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cfmactiv
    {
        public string Userid { get; set; } = null!;
        public string EbsForecastId { get; set; } = null!;
        public DateTime Logindat { get; set; }
        public DateTime Logintim { get; set; }
        public int DexRowId { get; set; }
    }
}
