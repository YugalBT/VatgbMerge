using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa00400
    {
        public int Assetindex { get; set; }
        public int Deprexpacctindx { get; set; }
        public int Deprresvacctindx { get; set; }
        public int Prioryrdepracctindx { get; set; }
        public int Assetcostacctindx { get; set; }
        public int Proceedsacctindx { get; set; }
        public int Recgainlossacctindx { get; set; }
        public int Nonrecgainlossacctindx { get; set; }
        public int Clearingacctindx { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
