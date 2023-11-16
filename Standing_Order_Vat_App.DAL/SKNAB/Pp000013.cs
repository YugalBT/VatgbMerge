using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pp000013
    {
        public string PpProfileName { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string DistRef { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
