using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl00105v
    {
        public int? Actindx { get; set; }
        public string? Actnumst { get; set; }
        public string? Actdescr { get; set; }
        public double? Prcntage { get; set; }
        public int? DexRowId { get; set; }
    }
}
