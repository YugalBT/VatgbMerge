using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd014
    {
        public short Remtype { get; set; }
        public string Remitid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public short Disttype { get; set; }
        public int Dstindx { get; set; }
        public byte Posted { get; set; }
        public DateTime Posteddt { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public string DistRef { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public short Dcstatus { get; set; }
        public int DexRowId { get; set; }
    }
}
