using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05002
    {
        public string RtvReturnStatus { get; set; } = null!;
        public string Stsdescr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
