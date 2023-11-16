using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa41200
    {
        public int Insclassindx { get; set; }
        public string Insclassid { get; set; } = null!;
        public string Insclassdesc { get; set; } = null!;
        public short Inflationratepct { get; set; }
        public short Deprratepct { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
