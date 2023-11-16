using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cpo10110
    {
        public string Ponumber { get; set; } = null!;
        public int Ord { get; set; }
        public int Actindx { get; set; }
        public DateTime Reqdate { get; set; }
        public string Vendorid { get; set; } = null!;
        public byte Approvl { get; set; }
        public decimal CommittedAmount { get; set; }
        public short Polnesta { get; set; }
        public decimal Qtycance { get; set; }
        public decimal Unitcost { get; set; }
        public decimal PostedSubtotal { get; set; }
        public int DexRowId { get; set; }
    }
}
