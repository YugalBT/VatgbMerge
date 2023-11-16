using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Bea40200
    {
        public string EmpidI { get; set; } = null!;
        public short IcInstanceNumberI { get; set; }
        public int SeqI { get; set; }
        public DateTime IdateI { get; set; }
        public byte IcAutoPostCbI { get; set; }
        public decimal IcAmountDueI { get; set; }
        public decimal IcAmountPaidI { get; set; }
        public decimal IcAmountDueTotalI { get; set; }
        public decimal IcAmountPaidTotalI { get; set; }
        public decimal IcBalanceI { get; set; }
        public string Dscriptn { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
