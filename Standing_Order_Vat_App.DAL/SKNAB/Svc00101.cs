using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00101
    {
        public string Techid { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public DateTime Strttime { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Endtme { get; set; }
        public string Techstat { get; set; } = null!;
        public string Techid2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
