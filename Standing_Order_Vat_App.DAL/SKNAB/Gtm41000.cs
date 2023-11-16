using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gtm41000
    {
        public short Cmpanyid { get; set; }
        public byte Enablegtm { get; set; }
        public int Uniquegrantid { get; set; }
        public string Usrdfpr1 { get; set; } = null!;
        public string Usrdrpr2 { get; set; } = null!;
        public string Usrdrpr3 { get; set; } = null!;
        public string Usrdrpr4 { get; set; } = null!;
        public string Usrdrpr5 { get; set; } = null!;
        public string Usrdrpr6 { get; set; } = null!;
        public string Usrdrpr7 { get; set; } = null!;
        public string Usrdrpr8 { get; set; } = null!;
        public string Usrdrpr9 { get; set; } = null!;
        public string Usrdrp10 { get; set; } = null!;
        public string Usrdrp11 { get; set; } = null!;
        public string Usrdrp12 { get; set; } = null!;
        public string AaTrxDim { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
