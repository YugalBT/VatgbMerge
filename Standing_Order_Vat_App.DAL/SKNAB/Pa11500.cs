using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa11500
    {
        public string Padocnumber20 { get; set; } = null!;
        public string Pacontnumber { get; set; } = null!;
        public decimal PabillingAmount { get; set; }
        public decimal Paconttotal { get; set; }
        public decimal Patottax { get; set; }
        public decimal Comdlram { get; set; }
        public short PaprojCounter { get; set; }
        public decimal PaorigBillAmount { get; set; }
        public decimal PaorigContractTotal { get; set; }
        public decimal PaorigTotalTaxAmt { get; set; }
        public decimal Orcomamt { get; set; }
        public int DexRowId { get; set; }
    }
}
