using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn00700
    {
        public short LetterType { get; set; }
        public string Ltrrptnm { get; set; } = null!;
        public string Ltrdesc { get; set; } = null!;
        public byte HideInLookup { get; set; }
        public string CnPrintUsingReport { get; set; } = null!;
        public string ActionPromised { get; set; } = null!;
        public string CnEmailSubject { get; set; } = null!;
        public byte CnWordLetter { get; set; }
        public string CnWordDocumentFile { get; set; } = null!;
        public int DexRowId { get; set; }
        public string CnLetterText { get; set; } = null!;
    }
}
