using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc30604
    {
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public int Lnitmseq { get; set; }
        public short Status { get; set; }
        public DateTime Posteddt { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Userid { get; set; } = null!;
        public decimal Pstdamnt { get; set; }
        public decimal OriginatingPostedAmount { get; set; }
        public string SourceTrxDocumentType { get; set; } = null!;
        public string SourceTrxDocumentNumber { get; set; } = null!;
        public decimal TransactionAmount { get; set; }
        public decimal OrigTransactionAmount { get; set; }
        public DateTime SvcCoverageStartDate { get; set; }
        public DateTime SvcCoverageEndDate { get; set; }
        public decimal SvcInvoiceCreditAmoun { get; set; }
        public decimal OrigInvCreditAmt { get; set; }
        public decimal Dscdlram { get; set; }
        public decimal Orddlrat { get; set; }
        public decimal NetTransactionAmount { get; set; }
        public decimal OrigNetTransactionAmount { get; set; }
        public short SvcContractVersion { get; set; }
        public int DexRowId { get; set; }
    }
}
