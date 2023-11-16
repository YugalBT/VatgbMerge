using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc36031v
    {
        public string Contnbr { get; set; } = null!;
        public short Consts { get; set; }
        public short SvcContractVersion { get; set; }
        public decimal? Docamnt { get; set; }
        public decimal? Pstdamnt { get; set; }
        public decimal? SvcInvoiceCreditAmoun { get; set; }
        public decimal? Ordocamt { get; set; }
        public decimal? Origpstdamnt { get; set; }
        public decimal? OrigInvCreditAmt { get; set; }
        public DateTime Invodate { get; set; }
        public byte Posted { get; set; }
        public int? DexRowId { get; set; }
    }
}
