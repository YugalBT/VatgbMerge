using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv30500
    {
        public short Ivdoctyp { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public int Actindx { get; set; }
        public short Disttype { get; set; }
        public DateTime Posteddt { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
