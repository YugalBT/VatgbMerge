using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv40202
    {
        public string Uomschdl { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Equivuom { get; set; } = null!;
        public decimal Equomqty { get; set; }
        public decimal Qtybsuom { get; set; }
        public string Uofmlongdesc { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
