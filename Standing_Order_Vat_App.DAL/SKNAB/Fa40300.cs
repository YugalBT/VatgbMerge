using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa40300
    {
        public string Userid { get; set; } = null!;
        public string Bookidarray1 { get; set; } = null!;
        public string Bookidarray2 { get; set; } = null!;
        public string Bookidarray3 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
