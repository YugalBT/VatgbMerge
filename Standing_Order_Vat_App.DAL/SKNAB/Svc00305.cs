using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00305
    {
        public int Equipid { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Serlnmbr { get; set; } = null!;
        public string Schedid { get; set; } = null!;
        public string Pmdtlid { get; set; } = null!;
        public int Meter1Level { get; set; }
        public int Meter2Level { get; set; }
        public string Callnbr { get; set; } = null!;
        public DateTime Lstpmdte { get; set; }
        public int Meter1 { get; set; }
        public int Meter2 { get; set; }
        public short Pmstat { get; set; }
        public DateTime Svclstpmperf { get; set; }
        public int DexRowId { get; set; }
    }
}
