using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06011
    {
        public string Routeid { get; set; } = null!;
        public decimal Sequence1 { get; set; }
        public string Dscriptn { get; set; } = null!;
        public string Depstatgrp { get; set; } = null!;
        public string Stationid { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public decimal Ettr { get; set; }
        public string Routeproc { get; set; } = null!;
        public string Servicebom { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
