using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Mc40201
    {
        public string Curncyid { get; set; } = null!;
        public int Realgain { get; set; }
        public int Realloss { get; set; }
        public int Unrlgain { get; set; }
        public int Unrlloss { get; set; }
        public int Finoffst { get; set; }
        public int Puroffst { get; set; }
        public int Slsoffst { get; set; }
        public int Rndwtoff { get; set; }
        public int Rnddiff { get; set; }
        public int DexRowId { get; set; }
    }
}
