using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc6105v
    {
        public string Stationid { get; set; } = null!;
        public string? Stationdesc { get; set; }
        public short Worectype { get; set; }
        public string Workordnum { get; set; } = null!;
        public decimal Sequence1 { get; set; }
        public string Dscriptn { get; set; } = null!;
        public short Status { get; set; }
        public string Wostatus { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public string? Wotype { get; set; }
        public string? Wostat { get; set; }
        public decimal? SvcDepotPriority { get; set; }
        public string? Offid { get; set; }
        public decimal Ettr { get; set; }
        public DateTime Etadte { get; set; }
        public DateTime Etatme { get; set; }
        public DateTime Ecompdt { get; set; }
        public DateTime EcompTime { get; set; }
        public DateTime? Strtdate { get; set; }
        public DateTime? Strttime { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? Endtime { get; set; }
        public string? Transtme { get; set; }
        public string? Eta { get; set; }
        public string? Ecomp { get; set; }
        public string? Actualstart { get; set; }
        public string? Actualend { get; set; }
        public int? Actualettr { get; set; }
        public int DexRowId { get; set; }
    }
}
