using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class Cifnumber
    {
        public int Acct { get; set; }
        public string? Type { get; set; }
        public string? Name { get; set; }
        public int? Cif { get; set; }
    }
}
