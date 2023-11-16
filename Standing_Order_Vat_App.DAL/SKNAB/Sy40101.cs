using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy40101
    {
        public short Year1 { get; set; }
        public DateTime Fstfscdy { get; set; }
        public DateTime Lstfscdy { get; set; }
        public short Numofper { get; set; }
        public byte Historyr { get; set; }
        public int DexRowId { get; set; }
    }
}
