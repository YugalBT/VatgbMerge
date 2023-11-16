using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06002
    {
        public string Depstatgrp { get; set; } = null!;
        public string Stationid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
