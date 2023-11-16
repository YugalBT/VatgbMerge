using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy02800
    {
        public string Userid { get; set; } = null!;
        public short Endtype { get; set; }
        public short Module1 { get; set; }
        public short Series { get; set; }
        public int DexRowId { get; set; }
    }
}
