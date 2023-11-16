using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pp000042
    {
        public short PpModule { get; set; }
        public short PpRecordType { get; set; }
        public int Ppoffseq { get; set; }
        public int PpSequencer { get; set; }
        public string PpDocumentNumber { get; set; } = null!;
        public string PpProfileName { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
