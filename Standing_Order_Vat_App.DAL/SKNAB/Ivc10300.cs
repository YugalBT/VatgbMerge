using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ivc10300
    {
        public short Doctype { get; set; }
        public string Invcnmbr { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public short Disttype { get; set; }
        public string DistRef { get; set; } = null!;
        public int Actindx { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public string Trxsorce { get; set; } = null!;
        public byte Posted { get; set; }
        public int DexRowId { get; set; }
    }
}
