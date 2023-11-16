using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv40702
    {
        public string Locncode { get; set; } = null!;
        public string Txrgnnum { get; set; } = null!;
        public string Ccode { get; set; } = null!;
        public string Tmcode { get; set; } = null!;
        public string Transnature { get; set; } = null!;
        public string Prcdrrgm { get; set; } = null!;
        public string Inctrms { get; set; } = null!;
        public string Prt { get; set; } = null!;
        public string Rgn { get; set; } = null!;
        public string Cntryorgn { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
