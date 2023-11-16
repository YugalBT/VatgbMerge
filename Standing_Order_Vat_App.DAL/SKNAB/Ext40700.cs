using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40700
    {
        public string PtViewId { get; set; } = null!;
        public string PtViewDescription { get; set; } = null!;
        public string ViewName { get; set; } = null!;
        public byte UseDisplayNames { get; set; }
        public byte SaveFieldsAsStrings { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public string Crusrid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
