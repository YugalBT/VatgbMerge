using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40103
    {
        public string PtWindowId { get; set; } = null!;
        public short SpecialCaseNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
