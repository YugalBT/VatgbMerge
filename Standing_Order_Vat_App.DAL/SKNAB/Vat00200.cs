using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Vat00200
    {
        public string Tcc { get; set; } = null!;
        public decimal Numass { get; set; }
        public string Protypecode { get; set; } = null!;
        public string Protypecodesc { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
