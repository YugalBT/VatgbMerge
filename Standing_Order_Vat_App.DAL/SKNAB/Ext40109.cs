using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40109
    {
        public string PtWindowId { get; set; } = null!;
        public short TemplateSelectionMethod { get; set; }
        public string TemplateId { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
