using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00651
    {
        public decimal Unitprct { get; set; }
        public short ContractPricePercent { get; set; }
        public string Opttype { get; set; } = null!;
        public byte ContractCumulativePric { get; set; }
        public string Itmclscd { get; set; } = null!;
        public decimal Unitprce { get; set; }
        public decimal Unitcost { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Custclas { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Pricshed { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
