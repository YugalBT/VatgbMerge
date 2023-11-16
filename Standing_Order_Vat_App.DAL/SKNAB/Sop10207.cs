using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop10207
    {
        public string Bachnumb { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
