using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Mc40500
    {
        public string Userid { get; set; } = null!;
        public short Series { get; set; }
        public string Trxsourc { get; set; } = null!;
        public short Viewtype { get; set; }
        public int DexRowId { get; set; }
    }
}
