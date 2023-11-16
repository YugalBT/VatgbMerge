using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00301
    {
        public int Equipid { get; set; }
        public int Lnitmseq { get; set; }
        public string Serlnmbr { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public int Meter1 { get; set; }
        public int Meter2 { get; set; }
        public int Meter3 { get; set; }
        public DateTime Lstdtedt { get; set; }
        public decimal DailyUsage { get; set; }
        public string Userid { get; set; } = null!;
        public int Meters1 { get; set; }
        public int Meters2 { get; set; }
        public int Meters3 { get; set; }
        public int Meters4 { get; set; }
        public int Meters5 { get; set; }
        public decimal Dailys1 { get; set; }
        public decimal Dailys2 { get; set; }
        public decimal Dailys3 { get; set; }
        public decimal Dailys4 { get; set; }
        public decimal Dailys5 { get; set; }
        public byte Replaces1 { get; set; }
        public byte Replaces2 { get; set; }
        public byte Replaces3 { get; set; }
        public byte Replaces4 { get; set; }
        public byte Replaces5 { get; set; }
        public string ReadingEnteredFrom { get; set; } = null!;
        public int MeterDeltas1 { get; set; }
        public int MeterDeltas2 { get; set; }
        public int MeterDeltas3 { get; set; }
        public int MeterDeltas4 { get; set; }
        public int MeterDeltas5 { get; set; }
        public int DexRowId { get; set; }
    }
}
