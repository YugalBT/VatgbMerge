using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc35210
    {
        public short ReturnRecordType { get; set; }
        public string Retdocid { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public decimal SvcProcessSeqNumber { get; set; }
        public int Sltsqnum { get; set; }
        public decimal ReturnQty { get; set; }
        public decimal SvcProcessQty { get; set; }
        public short SvcProcessType { get; set; }
        public short ReturnDispositionStatu { get; set; }
        public string SvcProcessStatus { get; set; } = null!;
        public string SvcDocumentNumber { get; set; } = null!;
        public decimal SvcIvSeqNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
