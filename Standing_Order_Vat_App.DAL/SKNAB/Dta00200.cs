using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Dta00200
    {
        public string Groupid { get; set; } = null!;
        public string Codeid { get; set; } = null!;
        public string Codedesc { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
