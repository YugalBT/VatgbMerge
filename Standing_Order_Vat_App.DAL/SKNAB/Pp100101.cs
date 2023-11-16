using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pp100101
    {
        public short PpModule { get; set; }
        public short PpRecordType { get; set; }
        public string PpDocumentNumber { get; set; } = null!;
        public int PpSequencer { get; set; }
        public int Ppoffseq { get; set; }
        public string Vchrnmbr { get; set; } = null!;
        public short Cntrltyp { get; set; }
        public int Dstsqnum { get; set; }
        public string Dscriptn { get; set; } = null!;
        public DateTime Glpostdt { get; set; }
        public decimal Trxamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
