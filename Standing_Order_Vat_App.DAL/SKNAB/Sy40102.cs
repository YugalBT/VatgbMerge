using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy40102
    {
        public byte Closed { get; set; }
        public short Series { get; set; }
        public string Odesctn { get; set; } = null!;
        public byte Forigin { get; set; }
        public short Periodid { get; set; }
        public DateTime Perioddt { get; set; }
        public string Pername { get; set; } = null!;
        public byte Pseries1 { get; set; }
        public byte Pseries2 { get; set; }
        public byte Pseries3 { get; set; }
        public byte Pseries4 { get; set; }
        public byte Pseries5 { get; set; }
        public byte Pseries6 { get; set; }
        public short Year1 { get; set; }
        public int DexRowId { get; set; }
    }
}
