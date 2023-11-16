using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Encbpo1
    {
        public string Ponumber { get; set; } = null!;
        public int Ord { get; set; }
        public short Polnesta { get; set; }
        public short Potype { get; set; }
        public short? Cntrlblktby { get; set; }
        public short LineNumber { get; set; }
        public decimal Extdcost { get; set; }
        public decimal Qtyorder { get; set; }
        public decimal Qtycance { get; set; }
        public decimal Unitcost { get; set; }
        public decimal? Remsubto { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Blnktlineextqtysum { get; set; }
        public int Invindx { get; set; }
        public DateTime Reqdate { get; set; }
        public string Uofm { get; set; } = null!;
        public decimal Umqtyinb { get; set; }
        public short Decplcur { get; set; }
        public short Decplqty { get; set; }
        public int Origin { get; set; }
    }
}
