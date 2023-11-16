using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pdk00200
    {
        public string Paletnme { get; set; } = null!;
        public short Palsqnum { get; set; }
        public string Palpmtnm { get; set; } = null!;
        public short Palcmdtp { get; set; }
        public string Paletcmd { get; set; } = null!;
        public string Aplicfil { get; set; } = null!;
        public short Dictid { get; set; }
        public short LanguageId { get; set; }
        public int DexRowId { get; set; }
    }
}
