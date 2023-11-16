using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy02500
    {
        public short Endtype { get; set; }
        public short Series { get; set; }
        public short Module1 { get; set; }
        public short Index1 { get; set; }
        public string Rutiname { get; set; } = null!;
        public DateTime Datedone { get; set; }
        public string Userid { get; set; } = null!;
        public short Palcmdtp { get; set; }
        public string Paletcmd { get; set; } = null!;
        public string Aplicfil { get; set; } = null!;
        public short Dictid { get; set; }
        public DateTime Time1 { get; set; }
        public int DexRowId { get; set; }
    }
}
