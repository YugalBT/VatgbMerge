using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pp000002
    {
        public string Userid { get; set; } = null!;
        public short Series { get; set; }
        public short Typeid { get; set; }
        public string Bachnumb { get; set; } = null!;
        public int Jrnentry { get; set; }
        public int Seqnumbr { get; set; }
        public int DexRowId { get; set; }
    }
}
