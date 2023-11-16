using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Bm00111
    {
        public string Itemnmbr { get; set; } = null!;
        public short BillStatus { get; set; }
        public int StatusOrd { get; set; }
        public int Ord { get; set; }
        public string Cmptitnm { get; set; } = null!;
        public short ComponentStatus { get; set; }
        public short BmCompState { get; set; }
        public short CostType { get; set; }
        public decimal DesignQty { get; set; }
        public short ScrapPercentage { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ObsoleteDate { get; set; }
        public string Uofm { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
