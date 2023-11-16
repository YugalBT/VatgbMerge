using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gst00103
    {
        public string Pavidn { get; set; } = null!;
        public byte TaxInvRecvd { get; set; }
        public byte TaxInvReqd { get; set; }
        public byte Aplywith { get; set; }
        public short Ppstaxrt { get; set; }
        public byte DocPrinted { get; set; }
        public decimal Frttxamt { get; set; }
        public decimal Orfrttax { get; set; }
        public decimal Msctxamt { get; set; }
        public decimal Ormsctax { get; set; }
        public int DexRowId { get; set; }
    }
}
