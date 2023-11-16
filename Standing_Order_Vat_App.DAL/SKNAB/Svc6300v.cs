using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc6300v
    {
        public string Stationid { get; set; } = null!;
        public short Status { get; set; }
        public string Wostatus { get; set; } = null!;
        public decimal SvcDepotPriority { get; set; }
        public string Workordnum { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public string? Name { get; set; }
        public string? Offid { get; set; }
        public decimal Ettr { get; set; }
        public DateTime Etadte { get; set; }
        public DateTime Etatme { get; set; }
        public DateTime Ecompdt { get; set; }
        public DateTime EcompTime { get; set; }
        public DateTime Actstrtdte { get; set; }
        public DateTime Actstrttme { get; set; }
        public string? Eta { get; set; }
        public string? Ecomp { get; set; }
        public string? Actualstart { get; set; }
        public int DexRowId { get; set; }
    }
}
