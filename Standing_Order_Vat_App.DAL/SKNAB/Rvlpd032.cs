using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd032
    {
        public string Userid { get; set; } = null!;
        public short NonUsedFieldsViewMode { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
