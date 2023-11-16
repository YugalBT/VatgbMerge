using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06103
    {
        public short Worectype { get; set; }
        public string Workordnum { get; set; } = null!;
        public string Stationid { get; set; } = null!;
        public short Status { get; set; }
        public decimal RouteSequence { get; set; }
        public string Techid { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public DateTime Strttime { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Endtime { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
