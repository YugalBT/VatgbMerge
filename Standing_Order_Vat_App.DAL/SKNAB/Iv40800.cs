using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv40800
    {
        public string Prclevel { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }
    }
}
