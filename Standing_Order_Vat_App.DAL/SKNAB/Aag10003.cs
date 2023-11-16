using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag10003
    {
        public int AaGlworkHdrId { get; set; }
        public int AaGlworkDistId { get; set; }
        public int AaGlworkAssignId { get; set; }
        public int AaTrxDimId { get; set; }
        public int AaTrxCodeId { get; set; }
        public byte[] AaCodeErrors { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
