using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv10303
    {
        public string Stckcntid { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Binnmbr { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public decimal Qtybsuom { get; set; }
        public decimal Countedqty { get; set; }
        public short Decplqty { get; set; }
        public int DexRowId { get; set; }
    }
}
