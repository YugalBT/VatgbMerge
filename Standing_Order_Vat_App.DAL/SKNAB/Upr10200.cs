using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10200
    {
        public string Userid { get; set; } = null!;
        public string Auctrlcd { get; set; } = null!;
        public string Bldchdid { get; set; } = null!;
        public DateTime Bldchkdt { get; set; }
        public DateTime Bldchtim { get; set; }
        public short Pyrntype { get; set; }
        public short Comppyrn { get; set; }
        public short Empclrng { get; set; }
        public string Sttempcl { get; set; } = null!;
        public string Enempcls { get; set; } = null!;
        public short Empidrng { get; set; }
        public string Sttempid { get; set; } = null!;
        public string Endempl { get; set; } = null!;
        public DateTime Pyrnstdt { get; set; }
        public DateTime Pyrnendt { get; set; }
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
        public short Pyrniptp { get; set; }
        public short Pyrnided { get; set; }
        public short Pyrnibft { get; set; }
        public int Dayswrdk { get; set; }
        public int Wkswrkd { get; set; }
        public byte Blchwrex { get; set; }
        public byte Bdcherex { get; set; }
        public byte Prchkptd { get; set; }
        public byte Pyrlchps { get; set; }
        public DateTime Chekdate { get; set; }
        public DateTime Posteddt { get; set; }
        public int Numoftrx { get; set; }
        public short Numofemp { get; set; }
        public int Cntrltrx { get; set; }
        public short Ctrlempct { get; set; }
        public byte Approvl { get; set; }
        public DateTime Apprvldt { get; set; }
        public string Aprvluserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
