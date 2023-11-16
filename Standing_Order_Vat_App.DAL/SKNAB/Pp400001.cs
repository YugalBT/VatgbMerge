using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pp400001
    {
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public short Series { get; set; }
        public short PpModule { get; set; }
        public short PpRecordType { get; set; }
        public string PpDocumentNumber { get; set; } = null!;
        public int PpSequencer { get; set; }
        public int Ppoffseq { get; set; }
        public decimal Trxamnt { get; set; }
        public byte PpSavedStatus { get; set; }
        public int DexRowId { get; set; }
    }
}
