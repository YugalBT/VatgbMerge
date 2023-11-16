using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa00199
    {
        public int Logindex { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public string Script { get; set; } = null!;
        public string MsgText { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
