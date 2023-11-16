using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag20003
    {
        public int AaSubLedgerHdrId { get; set; }
        public int AaSubLedgerDistId { get; set; }
        public int AaSubLedgerAssignId { get; set; }
        public int AaTrxDimId { get; set; }
        public int AaTrxCodeId { get; set; }
        public byte[] AaCodeErrors { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
