using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc35030
    {
        public short ReturnRecordType { get; set; }
        public string Retdocid { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public string Linitmtyp { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public decimal SvcProcessSeqNumber { get; set; }
        public short SvcDistributionType { get; set; }
        public string DistRef { get; set; } = null!;
        public int Actindx { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Orcrdamt { get; set; }
        public short Currnidx { get; set; }
        public string Trxsorce { get; set; } = null!;
        public byte Posted { get; set; }
        public DateTime Posteddt { get; set; }
        public int DexRowId { get; set; }
    }
}
