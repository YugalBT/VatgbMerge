using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00661
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
