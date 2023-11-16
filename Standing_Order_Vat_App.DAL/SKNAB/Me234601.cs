using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me234601
    {
        public string Userid { get; set; } = null!;
        public DateTime Userdate { get; set; }
        public DateTime Time1 { get; set; }
        public int DexRowId { get; set; }
    }
}
