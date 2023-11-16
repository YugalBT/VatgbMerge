using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me123519
    {
        public string OutputFormat { get; set; } = null!;
        public short MeTransactionType { get; set; }
        public string MeTrxMatchingCode { get; set; } = null!;
        public byte MeVoidTrxAmountsZero { get; set; }
        public byte MeOmitChecksWAlphas { get; set; }
        public int DexRowId { get; set; }
    }
}
