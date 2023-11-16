using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr00402
    {
        public string Employid { get; set; } = null!;
        public string Payrcord { get; set; } = null!;
        public DateTime EffectiveDate { get; set; }
        public decimal Payrtamt { get; set; }
        public string ChangereasonI { get; set; } = null!;
        public short PayStepStatus { get; set; }
        public string Pystptblid { get; set; } = null!;
        public short Step { get; set; }
        public int DexRowId { get; set; }
    }
}
