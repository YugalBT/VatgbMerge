using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa40203
    {
        public string Userid { get; set; } = null!;
        public int Bookindx { get; set; }
        public string Bookid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
