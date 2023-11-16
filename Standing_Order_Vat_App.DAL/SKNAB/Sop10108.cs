using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop10108
    {
        public string Prcgrpid { get; set; } = null!;
        public string Descexpr { get; set; } = null!;
        public short Decplcur { get; set; }
        public short Decplqty { get; set; }
        public string Uomschdl { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
