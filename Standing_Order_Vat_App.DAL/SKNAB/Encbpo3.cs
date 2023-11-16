using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Encbpo3
    {
        public string Ponumber { get; set; } = null!;
        public int Ord { get; set; }
        public short Polnesta { get; set; }
        public short Potype { get; set; }
        public short? Cntrlblktby { get; set; }
        public short Encbstat { get; set; }
        public decimal Qtyorder { get; set; }
        public decimal Qtycance { get; set; }
        public decimal Unitcost { get; set; }
        public decimal PoAmt { get; set; }
        public decimal ParentAmt { get; set; }
        public decimal ParenthistAmt { get; set; }
        public decimal ChildAmt { get; set; }
        public decimal ChildhistAmt { get; set; }
        public decimal LiquidAmt { get; set; }
        public decimal? PopChildAmtByQty { get; set; }
        public decimal? PopChildAmtByValue { get; set; }
        public decimal? EncChildAmtByQty { get; set; }
        public decimal? EncChildAmtByValue { get; set; }
        public decimal? PopHdrAmtByQty { get; set; }
        public decimal? PopHdrAmtByValue { get; set; }
    }
}
