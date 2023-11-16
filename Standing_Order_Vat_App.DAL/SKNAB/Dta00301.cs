using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Dta00301
    {
        public int Actindx { get; set; }
        public string Groupid { get; set; } = null!;
        public string Codeid { get; set; } = null!;
        public string Postdesc { get; set; } = null!;
        public short Percentamount { get; set; }
        public int DexRowId { get; set; }
    }
}
