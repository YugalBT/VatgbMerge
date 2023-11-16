using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Palbdtl
    {
        public string LockboxId { get; set; } = null!;
        public short PaRowType { get; set; }
        public short PaFieldNumber { get; set; }
        public short PaMapsTo { get; set; }
        public short PaStartPosition { get; set; }
        public short EndPosition { get; set; }
        public int DexRowId { get; set; }
    }
}
