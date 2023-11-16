using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06105
    {
        public short Worectype { get; set; }
        public string Workordnum { get; set; } = null!;
        public short Status { get; set; }
        public decimal Sequence1 { get; set; }
        public string Dscriptn { get; set; } = null!;
        public string Depstatgrp { get; set; } = null!;
        public string Stationid { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public decimal Ettr { get; set; }
        public string Routeproc { get; set; } = null!;
        public string Servicebom { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public DateTime Strttime { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Endtime { get; set; }
        public DateTime Etadte { get; set; }
        public DateTime Etatme { get; set; }
        public DateTime Ecompdt { get; set; }
        public DateTime EcompTime { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
