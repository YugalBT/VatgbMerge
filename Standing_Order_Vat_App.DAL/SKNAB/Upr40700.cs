using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr40700
    {
        public string Wrkrcomp { get; set; } = null!;
        public string Statecd { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public short Wkcmpmth { get; set; }
        public decimal Wkcmpamt { get; set; }
        public decimal Wkcmpunt { get; set; }
        public int Wkcmpcnt { get; set; }
        public short Wcmotmth { get; set; }
        public decimal Wcwglimt { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
