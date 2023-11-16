using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa40201
    {
        public int Assetclassindx { get; set; }
        public string Assetclassid { get; set; } = null!;
        public string Assetclassiddesc { get; set; } = null!;
        public int Defacctgrpindx { get; set; }
        public int Definsclassindx { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
