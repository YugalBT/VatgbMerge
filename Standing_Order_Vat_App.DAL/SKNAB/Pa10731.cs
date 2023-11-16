using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa10731
    {
        public string Popivcno { get; set; } = null!;
        public int Ivclinno { get; set; }
        public string Pavidn { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public int Lclinenumber { get; set; }
        public decimal Unitcost { get; set; }
        public int DexRowId { get; set; }
    }
}
