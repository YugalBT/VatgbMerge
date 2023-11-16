using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06200
    {
        public string Servicebom { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
