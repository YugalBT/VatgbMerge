using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa41100
    {
        public int Locationindx { get; set; }
        public string Locatnid { get; set; } = null!;
        public string Statedescr { get; set; } = null!;
        public string Countydescr { get; set; } = null!;
        public string Citydescr { get; set; } = null!;
        public string Stateabbrev { get; set; } = null!;
        public string Statecd { get; set; } = null!;
        public string Countycode { get; set; } = null!;
        public string Citycode { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
