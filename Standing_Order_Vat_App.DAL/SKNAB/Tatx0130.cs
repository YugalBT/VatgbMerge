using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Tatx0130
    {
        public string Trxsorce { get; set; } = null!;
        public int TrxI { get; set; }
        public int DexRowId { get; set; }
    }
}
