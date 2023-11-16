using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me142814
    {
        public string Mebankid { get; set; } = null!;
        public short MeLineType { get; set; }
        public short MeFieldNumber { get; set; }
        public short MeFromPosition { get; set; }
        public short MeToPosition { get; set; }
        public short MeFieldType { get; set; }
        public short MeFieldFormat { get; set; }
        public int DexRowId { get; set; }
    }
}
