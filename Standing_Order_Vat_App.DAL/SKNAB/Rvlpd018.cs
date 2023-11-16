using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd018
    {
        public short Keynumbr { get; set; }
        public int PayPmntDocGlacctIdx { get; set; }
        public int GivePmntDocGlacctIdx { get; set; }
        public short PayGlentryLevel { get; set; }
        public int DexRowId { get; set; }
    }
}
