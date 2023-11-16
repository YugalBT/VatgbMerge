using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06015
    {
        public string Routeid { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
