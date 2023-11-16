using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ahrvac12
    {
        public DateTime IdateI { get; set; }
        public string EmpidI { get; set; } = null!;
        public string Str30dummyI { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
