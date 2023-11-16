using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn20101
    {
        public string Custnmbr { get; set; } = null!;
        public string Cprcstnm { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; } = null!;
        public short CnCreditLevel { get; set; }
        public DateTime CnLetterDate { get; set; }
        public decimal CreditLevelFee { get; set; }
        public int DexRowId { get; set; }
    }
}
