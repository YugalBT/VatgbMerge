using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40110
    {
        public string PtWindowId { get; set; } = null!;
        public string TemplateId { get; set; } = null!;
        public string TemplateDescription { get; set; } = null!;
        public short ReplacementRule { get; set; }
        public short Rcrdtype { get; set; }
        public short WindowNumber { get; set; }
        public short FieldNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
