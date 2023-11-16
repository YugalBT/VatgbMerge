using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Af40200
    {
        public short Reportid { get; set; }
        public decimal RptOptId { get; set; }
        public short Rownmbr { get; set; }
        public int Nmbracts { get; set; }
        public int DexRowId { get; set; }
    }
}
