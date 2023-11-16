using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Bm00101
    {
        public string Itemnmbr { get; set; } = null!;
        public short BillStatus { get; set; }
        public int StatusOrd { get; set; }
        public short BmStockMethod { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ObsoleteDate { get; set; }
        public string Uofm { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }
    }
}
