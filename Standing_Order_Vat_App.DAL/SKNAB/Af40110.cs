using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Af40110
    {
        public string Username { get; set; } = null!;
        public byte Shgrdflg { get; set; }
        public byte Shcgrflg { get; set; }
        public byte Shtbarfl { get; set; }
        public byte Scdefafl { get; set; }
        public byte Shrwarfl { get; set; }
        public byte Shofmkfl { get; set; }
        public byte Snptgrfl { get; set; }
        public byte Shmarflg { get; set; }
        public byte Shpgbdfl { get; set; }
        public byte Shrlrsfl { get; set; }
        public int DexRowId { get; set; }
    }
}
