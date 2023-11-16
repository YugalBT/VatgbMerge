using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00997
    {
        public string SvcModule { get; set; } = null!;
        public string SvcFormName { get; set; } = null!;
        public string SvcWindowName { get; set; } = null!;
        public string SvcOption { get; set; } = null!;
        public string SvcOptionDesc { get; set; } = null!;
        public byte SvcOptionEnabled { get; set; }
        public string SvcOptionPswd { get; set; } = null!;
        public short SvcDocType { get; set; }
        public int DexRowId { get; set; }
    }
}
