using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrpred01
    {
        public string Employid { get; set; } = null!;
        public string Payrcord { get; set; } = null!;
        public short RedlinetypeI { get; set; }
        public int DexRowId { get; set; }
    }
}
