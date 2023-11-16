using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00654
    {
        public string Pricshed { get; set; } = null!;
        public string Itmclscd { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Custclas { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public decimal Unitcost { get; set; }
        public decimal Unitprce { get; set; }
        public int DexRowId { get; set; }
    }
}
