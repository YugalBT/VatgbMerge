using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn40300
    {
        public short CnCreditLevel { get; set; }
        public string CnCreditDescription { get; set; } = null!;
        public decimal CreditLevelFee { get; set; }
        public string CnControlLevelAbrv { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
