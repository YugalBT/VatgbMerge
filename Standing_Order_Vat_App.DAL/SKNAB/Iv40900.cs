using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv40900
    {
        public string PriceGroup { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
