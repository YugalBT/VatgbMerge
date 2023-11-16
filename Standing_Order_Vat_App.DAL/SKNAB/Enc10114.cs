using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Enc10114
    {
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public string Pername { get; set; } = null!;
        public int Actindx { get; set; }
        public string? Actnumst { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
