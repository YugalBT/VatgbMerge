using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Tx00203
    {
        public short Histtype { get; set; }
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public string Taxdtlid { get; set; } = null!;
        public decimal Tdtslpch { get; set; }
        public decimal Txdttxsp { get; set; }
        public decimal Txdtsptx { get; set; }
        public int DexRowId { get; set; }
    }
}
