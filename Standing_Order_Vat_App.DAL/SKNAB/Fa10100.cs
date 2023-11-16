using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa10100
    {
        public string Userid { get; set; } = null!;
        public string Groupname { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public int DexRowId { get; set; }
    }
}
