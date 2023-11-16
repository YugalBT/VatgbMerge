using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Enc00118
    {
        public string Ponumber { get; set; } = null!;
        public int Ord { get; set; }
        public short LineNumber { get; set; }
        public short Polnesta { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Umqtyinb { get; set; }
        public decimal Qtychild { get; set; }
        public decimal AmtByQty { get; set; }
        public decimal AmtByValue { get; set; }
    }
}
