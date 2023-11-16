using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm10100
    {
        public string Chekbkid { get; set; } = null!;
        public string Depositnumber { get; set; } = null!;
        public short Deptype { get; set; }
        public byte Depwthrct { get; set; }
        public DateTime Depdate { get; set; }
        public DateTime Glpostdt { get; set; }
        public decimal DepAmt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public string Curncyid { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public short Rcrdstts { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public DateTime Expndate { get; set; }
        public short Currnidx { get; set; }
        public short Decplcur { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public int DexRowId { get; set; }
    }
}
