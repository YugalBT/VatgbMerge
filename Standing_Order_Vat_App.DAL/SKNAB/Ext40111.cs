using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40111
    {
        public string PtWindowId { get; set; } = null!;
        public string TemplateId { get; set; } = null!;
        public short FieldNumber { get; set; }
        public string Strga255 { get; set; } = null!;
        public decimal Total { get; set; }
        public short TemplateDateOption { get; set; }
        public short TemplateNumberOption { get; set; }
        public short TemplateTimeOption { get; set; }
        public short ReplacementRule { get; set; }
        public byte RandomCb { get; set; }
        public short TemplateFieldType { get; set; }
        public int DexRowId { get; set; }
    }
}
