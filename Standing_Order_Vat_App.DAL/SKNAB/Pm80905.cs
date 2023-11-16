using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm80905
    {
        public string Userid { get; set; } = null!;
        public string Vchrnmbr { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public short Doctype { get; set; }
        public int DexRowId { get; set; }
    }
}
