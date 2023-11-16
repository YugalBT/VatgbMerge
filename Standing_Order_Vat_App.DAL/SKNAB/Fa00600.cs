using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa00600
    {
        public int Assetindex { get; set; }
        public int Insclassindx { get; set; }
        public short Insuranceyear { get; set; }
        public decimal Insurancevalue { get; set; }
        public decimal Replacementcost { get; set; }
        public decimal Reprocost { get; set; }
        public decimal Deprreprocost { get; set; }
        public decimal Exclusionamt { get; set; }
        public string Exclusiontype { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
