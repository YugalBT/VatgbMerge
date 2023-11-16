using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc60400v
    {
        public string Contnbr { get; set; } = null!;
        public short Consts { get; set; }
        public decimal Lnseqnbr { get; set; }
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public decimal? TransactionAmount { get; set; }
        public decimal? OrigTransactionAmount { get; set; }
        public decimal? Dscdlram { get; set; }
        public decimal? Orddlrat { get; set; }
        public decimal? NetTransactionAmount { get; set; }
        public decimal? OrigNetTransactionAmount { get; set; }
        public decimal? Pstdamnt { get; set; }
        public decimal? OriginatingPostedAmount { get; set; }
        public int? DexRowId { get; set; }
    }
}
