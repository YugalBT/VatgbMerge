using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa41000
    {
        public int Quarterindx { get; set; }
        public short Year1 { get; set; }
        public short Quarterid { get; set; }
        public DateTime Quarterstartdate { get; set; }
        public DateTime Quarterenddate { get; set; }
        public DateTime Quartermiddate { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
