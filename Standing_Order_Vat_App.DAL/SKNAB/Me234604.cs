using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me234604
    {
        public string MeEftGenerationTimest { get; set; } = null!;
        public decimal TotCrdAmt { get; set; }
        public string Userid { get; set; } = null!;
        public decimal MeTotalDebitAmount { get; set; }
        public short MeTotalNumberOfBatch { get; set; }
        public int MeTotalNumberOfCredi { get; set; }
        public int MeTotalNumberOfDebit { get; set; }
        public string Chekbkid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
