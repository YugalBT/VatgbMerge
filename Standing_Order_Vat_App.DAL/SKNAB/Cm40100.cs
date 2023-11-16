using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm40100
    {
        public decimal Cmrecnum { get; set; }
        public int Nxtnum { get; set; }
        public byte Cmhistory { get; set; }
        public string Usrdfpr1 { get; set; } = null!;
        public string Usrdrpr2 { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
