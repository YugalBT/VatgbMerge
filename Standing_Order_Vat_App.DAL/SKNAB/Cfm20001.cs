using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cfm20001
    {
        public int Seqnumbr { get; set; }
        public DateTime Duedate { get; set; }
        public string Dscriptn { get; set; } = null!;
        public decimal CfmAmount { get; set; }
        public int DexRowId { get; set; }
    }
}
