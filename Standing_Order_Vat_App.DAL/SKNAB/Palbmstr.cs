using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Palbmstr
    {
        public string LockboxId { get; set; } = null!;
        public string LockboxDescription { get; set; } = null!;
        public short PaLockboxFormatType { get; set; }
        public string Strga255 { get; set; } = null!;
        public string LockboxFileName { get; set; } = null!;
        public short Xprtftyp { get; set; }
        public string Chekbkid { get; set; } = null!;
        public short PaApplyMethod { get; set; }
        public short PaApplyMethodInvoice { get; set; }
        public short Decplcur { get; set; }
        public int OmitStartRecords { get; set; }
        public int OmitLastRecords { get; set; }
        public string PaHeaderRowIndicator { get; set; } = null!;
        public string PaDeailRowIndicator { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }
    }
}
