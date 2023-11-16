using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc30605
    {
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public string Sopnumbe { get; set; } = null!;
        public short Soptype { get; set; }
        public DateTime Invodate { get; set; }
        public decimal InvoicedAmount { get; set; }
        public decimal AmountToInvoice { get; set; }
        public decimal OrigInvoicedAmount { get; set; }
        public decimal OrigAmountToInvoice { get; set; }
        public short SvcContractVersion { get; set; }
        public int DexRowId { get; set; }
    }
}
