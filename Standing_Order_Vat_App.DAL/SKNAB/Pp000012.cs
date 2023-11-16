using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pp000012
    {
        public short PpModule { get; set; }
        public short PpRecordType { get; set; }
        public string PpDocumentNumber { get; set; } = null!;
        public int Ppoffseq { get; set; }
        public int PpSequencer { get; set; }
        public short Disttype { get; set; }
        public string PpProfileName { get; set; } = null!;
        public int Offindx { get; set; }
        public int Actindx { get; set; }
        public int PpDeferredBcIndex { get; set; }
        public int PpDeferralsTransferIn { get; set; }
        public int PpRecognitionIndex { get; set; }
        public short PpCalculationMethod { get; set; }
        public DateTime Strtngdt { get; set; }
        public DateTime Endingdt { get; set; }
        public short Numofper { get; set; }
        public decimal Noteindx { get; set; }
        public byte PpOverwriteOriginalDi { get; set; }
        public short PpMiscellaneousPeriods { get; set; }
        public int DexRowId { get; set; }
    }
}
