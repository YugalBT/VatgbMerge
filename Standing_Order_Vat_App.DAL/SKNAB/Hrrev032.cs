using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrrev032
    {
        public string ReviewsetupcodeI { get; set; } = null!;
        public string RevintltitlesI { get; set; } = null!;
        public short RevintsequenceI { get; set; }
        public int DexRowId { get; set; }
    }
}
