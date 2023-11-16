using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn04000
    {
        public DateTime Strtdate { get; set; }
        public int Seqnumbr { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Datedone { get; set; }
        public decimal Slsamnt { get; set; }
        public decimal OutstandingAmount { get; set; }
        public short Nmbrofdys { get; set; }
        public int DexRowId { get; set; }
    }
}
