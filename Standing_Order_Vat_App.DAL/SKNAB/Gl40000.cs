using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl40000
    {
        public string Uniqkey { get; set; } = null!;
        public int Njrnlent { get; set; }
        public int Rerindx { get; set; }
        public DateTime Lstclsdt { get; set; }
        public byte Trerclsg { get; set; }
        public short Divactsg { get; set; }
        public short Blncdspl { get; set; }
        public byte Kpgachst { get; set; }
        public byte Kpgtrxhs { get; set; }
        public byte Ahstpstg { get; set; }
        public string Usrdfpr1 { get; set; } = null!;
        public string Usrdrpr2 { get; set; } = null!;
        public string Usrdrpr3 { get; set; } = null!;
        public string Usrdrpr4 { get; set; } = null!;
        public byte Updtaccel { get; set; }
        public short PostingNumberType { get; set; }
        public byte DeleteSavedTrx { get; set; }
        public byte VoidSubTrx { get; set; }
        public byte CorrectIcTrx { get; set; }
        public int DexRowId { get; set; }
    }
}
