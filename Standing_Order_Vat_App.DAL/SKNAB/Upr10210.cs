using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10210
    {
        public string Bldchdid { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public short Comppyrn { get; set; }
        public DateTime Pyrnstdt { get; set; }
        public DateTime Pyrnendt { get; set; }
        public short Empclrng { get; set; }
        public string Sttempcl { get; set; } = null!;
        public string Enempcls { get; set; } = null!;
        public short Empidrng { get; set; }
        public string Sttempid { get; set; } = null!;
        public string Endempl { get; set; } = null!;
        public byte Pyrniwly { get; set; }
        public byte Pyrnibwk { get; set; }
        public byte Prnismly { get; set; }
        public byte Pyrnimly { get; set; }
        public byte Pyrniqly { get; set; }
        public byte Pyrnisan { get; set; }
        public byte Pyrniann { get; set; }
        public byte Pyrnidms { get; set; }
        public byte Pyrnisry { get; set; }
        public byte Pyrnipsn { get; set; }
        public byte Pyrnieic { get; set; }
        public int Dayswrdk { get; set; }
        public int Wkswrkd { get; set; }
        public short Pyrniptp { get; set; }
        public short Pyrnided { get; set; }
        public short Pyrnibft { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
