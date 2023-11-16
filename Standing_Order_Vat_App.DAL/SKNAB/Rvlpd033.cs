using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd033
    {
        public short Cmpanyid { get; set; }
        public string Userid { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public int DexRowId { get; set; }
    }
}
