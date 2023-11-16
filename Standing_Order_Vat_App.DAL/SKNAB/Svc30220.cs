using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc30220
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; } = null!;
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public decimal InvoicedAmount { get; set; }
        public decimal AmountToInvoice { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Createtime { get; set; }
        public int DexRowId { get; set; }
    }
}
