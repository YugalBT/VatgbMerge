using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl00103
    {
        public int Actindx { get; set; }
        public decimal Prcntage { get; set; }
        public int Dstindx { get; set; }
        public int DexRowId { get; set; }
    }
}
