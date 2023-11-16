using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10215
    {
        public string Userid { get; set; } = null!;
        public short Pyrntype { get; set; }
        public string Employid { get; set; } = null!;
        public int Pyadnmbr { get; set; }
        public string Rsnchkvd { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
