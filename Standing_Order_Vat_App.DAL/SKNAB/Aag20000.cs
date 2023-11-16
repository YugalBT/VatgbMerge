using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag20000
    {
        public int AaSubLedgerHdrId { get; set; }
        public short Series { get; set; }
        public short Doctype { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string MasterId { get; set; } = null!;
        public byte[] AaHdrErrors { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
