using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag60000
    {
        public string Userid { get; set; } = null!;
        public string Trxbtchsrc { get; set; } = null!;
        public int AaGlworkHdrId { get; set; }
        public int Jrnentry { get; set; }
        public short Series { get; set; }
        public DateTime Glpostdt { get; set; }
        public int DexRowId { get; set; }
    }
}
