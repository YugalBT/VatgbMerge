using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Tx00302
    {
        public DateTime EffectiveDate { get; set; }
        public decimal EuInputTaxRate { get; set; }
        public int DexRowId { get; set; }
    }
}
