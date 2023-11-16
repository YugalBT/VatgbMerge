using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag10002
    {
        public int AaGlworkHdrId { get; set; }
        public int AaGlworkDistId { get; set; }
        public int AaGlworkAssignId { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public int AaAssignedPercent { get; set; }
        public string DistRef { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public byte[] AaAssignErrors { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
