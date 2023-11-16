using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv41000
    {
        public short Setupkey { get; set; }
        public short Numbershifts { get; set; }
        public decimal Hrsprshft { get; set; }
        public DateTime Strttime { get; set; }
        public short Dwnonwknds { get; set; }
        public int DexRowId { get; set; }
    }
}
