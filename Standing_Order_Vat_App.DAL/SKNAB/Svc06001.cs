using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06001
    {
        public string Stationid { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public byte Workdys1 { get; set; }
        public byte Workdys2 { get; set; }
        public byte Workdys3 { get; set; }
        public byte Workdys4 { get; set; }
        public byte Workdys5 { get; set; }
        public byte Workdys6 { get; set; }
        public byte Workdys7 { get; set; }
        public DateTime Workstrt1 { get; set; }
        public DateTime Workstrt2 { get; set; }
        public DateTime Workstrt3 { get; set; }
        public DateTime Workstrt4 { get; set; }
        public DateTime Workstrt5 { get; set; }
        public DateTime Workstrt6 { get; set; }
        public DateTime Workstrt7 { get; set; }
        public DateTime Workend1 { get; set; }
        public DateTime Workend2 { get; set; }
        public DateTime Workend3 { get; set; }
        public DateTime Workend4 { get; set; }
        public DateTime Workend5 { get; set; }
        public DateTime Workend6 { get; set; }
        public DateTime Workend7 { get; set; }
        public short Pretime { get; set; }
        public short Posttime { get; set; }
        public int DexRowId { get; set; }
    }
}
