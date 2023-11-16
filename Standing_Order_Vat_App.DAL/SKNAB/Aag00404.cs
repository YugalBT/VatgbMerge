using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00404
    {
        public int AaTrxDimId { get; set; }
        public int AaTrxDimCodeDateId { get; set; }
        public DateTime AaTrxDimCodeDate { get; set; }
        public int DexRowId { get; set; }
    }
}
