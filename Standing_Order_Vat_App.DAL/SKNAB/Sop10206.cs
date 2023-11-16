using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop10206
    {
        public string Bachnumb { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public DateTime BulkPrintDate { get; set; }
        public short Timesprt { get; set; }
        public int DexRowId { get; set; }
    }
}
