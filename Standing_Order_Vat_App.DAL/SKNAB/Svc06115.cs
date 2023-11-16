using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06115
    {
        public byte Mkdtopst { get; set; }
        public short Worectype { get; set; }
        public string Workordnum { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public string Wotype { get; set; } = null!;
        public string Stationid { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public byte Posted { get; set; }
        public short Ermsgnbr { get; set; }
        public string Ermsgtxt { get; set; } = null!;
        public string Ermsgtx2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
