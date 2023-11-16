using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05501
    {
        public string Rettype { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Retstat { get; set; } = null!;
        public string ReceivedStatus { get; set; } = null!;
        public string ShippingStatus { get; set; } = null!;
        public string CloseStatus { get; set; } = null!;
        public short Retpath { get; set; }
        public string Vndwarrtype { get; set; } = null!;
        public string RtvType { get; set; } = null!;
        public string Depottype { get; set; } = null!;
        public string Orddocid { get; set; } = null!;
        public string Crdocid { get; set; } = null!;
        public string Invdocid { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Itlocn { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string SvcDiscrepancyStatus { get; set; } = null!;
        public string SvcRmaInvoiceBatchId { get; set; } = null!;
        public string SvcRmaCreditBatchId { get; set; } = null!;
        public string SvcRmaOrderBatchId { get; set; } = null!;
        public int SvcSalesReturnIndex { get; set; }
        public int SvcCogsIndex { get; set; }
        public int SvcScrapIndex { get; set; }
        public int SvcRepairSalesIndex { get; set; }
        public string SvcPartialReceivedSta { get; set; } = null!;
        public string SvcReadyToCloseStatu { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
