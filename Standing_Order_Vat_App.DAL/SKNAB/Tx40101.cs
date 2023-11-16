using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Tx40101
    {
        public short Setupkey { get; set; }
        public DateTime Lstclsdt { get; set; }
        public int DexRowId { get; set; }
    }
}
