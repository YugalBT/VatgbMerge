using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01211
    {
        public string Pacontnumber { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public short PabillingMode { get; set; }
        public decimal ParevSourceAmt { get; set; }
        public decimal ParevSourcePercent { get; set; }
        public int DexRowId { get; set; }
    }
}
