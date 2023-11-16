using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2trx01
    {
        public string EmpidI { get; set; } = null!;
        public string CompanycodeI { get; set; } = null!;
        public short ExporttypeI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public int DexRowId { get; set; }
    }
}
