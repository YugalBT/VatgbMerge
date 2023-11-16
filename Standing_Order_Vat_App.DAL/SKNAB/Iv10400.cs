using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv10400
    {
        public string Prcgrpid { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public int DexRowId { get; set; }
    }
}
