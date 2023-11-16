using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop10110
    {
        public string Prcshid { get; set; } = null!;
        public string Descexpr { get; set; } = null!;
        public byte Ntpronly { get; set; }
        public byte Active { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public decimal Noteindx { get; set; }
        public byte Promo { get; set; }
        public string Curncyid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
