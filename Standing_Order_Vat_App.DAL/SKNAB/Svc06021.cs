using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06021
    {
        public string Wotype { get; set; } = null!;
        public decimal Sqncline { get; set; }
        public string Wostat { get; set; } = null!;
        public string Stationid { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public int Waittme { get; set; }
        public int DexRowId { get; set; }
    }
}
