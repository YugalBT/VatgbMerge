using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00951
    {
        public string Uomschdl { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public byte Metered { get; set; }
        public byte Rtrnable { get; set; }
        public string Prdline { get; set; } = null!;
        public string Warrcde { get; set; } = null!;
        public decimal Mtbf { get; set; }
        public decimal Mtbi { get; set; }
        public decimal Mttr { get; set; }
        public decimal Retcost { get; set; }
        public byte SvcPmAllowed { get; set; }
        public byte SvcContractible { get; set; }
        public string Slrwarr { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public byte SvcUseCurrentCost { get; set; }
        public int DexRowId { get; set; }
    }
}
