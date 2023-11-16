using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv00118
    {
        public string Itemnmbr { get; set; } = null!;
        public int Ord { get; set; }
        public decimal Prevcost { get; set; }
        public decimal Presentcost { get; set; }
        public DateTime ChangedateI { get; set; }
        public DateTime Time1 { get; set; }
        public string ChangebyI { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
