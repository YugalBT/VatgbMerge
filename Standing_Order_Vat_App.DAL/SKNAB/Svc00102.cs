using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00102
    {
        public string Techid { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Probcde { get; set; } = null!;
        public string Crsenbr { get; set; } = null!;
        public string Certnum { get; set; } = null!;
        public DateTime Certdte { get; set; }
        public DateTime Expndate { get; set; }
        public int DexRowId { get; set; }
    }
}
