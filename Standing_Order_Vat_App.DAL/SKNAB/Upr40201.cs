using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr40201
    {
        public short Setupkey { get; set; }
        public byte Autoasgnempid { get; set; }
        public string Nextempid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
