using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pp000010
    {
        public string PpProfileName { get; set; } = null!;
        public short PpModule { get; set; }
        public int Offindx { get; set; }
        public int Actindx { get; set; }
        public int PpDeferredBcIndex { get; set; }
        public int PpDeferralsTransferIn { get; set; }
        public int PpRecognitionIndex { get; set; }
        public short PpCalculationMethod { get; set; }
        public short PpDebitCredit1 { get; set; }
        public short PpDebitCredit2 { get; set; }
        public short PpDebitCredit3 { get; set; }
        public short PpDebitCredit4 { get; set; }
        public short PpDebitCredit5 { get; set; }
        public short PpDebitCredit6 { get; set; }
        public short PpDebitCredit7 { get; set; }
        public short PpDebitCredit8 { get; set; }
        public short PpDebitCredit9 { get; set; }
        public short PpDebitCredit10 { get; set; }
        public DateTime Strtngdt { get; set; }
        public DateTime Endingdt { get; set; }
        public short Numofper { get; set; }
        public decimal Noteindx { get; set; }
        public byte PpOverwriteOriginalDi { get; set; }
        public short PpMiscellaneousPeriods { get; set; }
        public int DexRowId { get; set; }
    }
}
