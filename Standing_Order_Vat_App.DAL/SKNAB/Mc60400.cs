using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Mc60400
    {
        public string Denomcurr { get; set; } = null!;
        public byte Enabled { get; set; }
        public string Userid { get; set; } = null!;
        public int Realgain { get; set; }
        public int Realloss { get; set; }
        public DateTime Pstgdate { get; set; }
        public int DexRowId { get; set; }
    }
}
