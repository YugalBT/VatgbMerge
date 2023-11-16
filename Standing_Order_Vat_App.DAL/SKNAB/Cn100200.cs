using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn100200
    {
        public string Userid { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public int DexRowId { get; set; }
        public string Txtfield { get; set; } = null!;
    }
}
