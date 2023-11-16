using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00603
    {
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public int SvcInvoiceSeqNumber { get; set; }
        public DateTime Invodate { get; set; }
        public decimal Docamnt { get; set; }
        public DateTime SvcCoverageStartDate { get; set; }
        public DateTime SvcCoverageEndDate { get; set; }
        public byte Posted { get; set; }
        public DateTime Posteddt { get; set; }
        public decimal Pstdamnt { get; set; }
        public decimal SvcInvoiceCreditAmoun { get; set; }
        public decimal SvcDailyRate { get; set; }
        public decimal Dscdlram { get; set; }
        public decimal Ordocamt { get; set; }
        public decimal Origpstdamnt { get; set; }
        public decimal OrigInvCreditAmt { get; set; }
        public decimal Orddlrat { get; set; }
        public int DexRowId { get; set; }
    }
}
