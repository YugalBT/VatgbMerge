using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gst00111
    {
        public string Vndclsid { get; set; } = null!;
        public byte TaxInvRecvd { get; set; }
        public short WithholdingType { get; set; }
        public int DexRowId { get; set; }
    }
}
