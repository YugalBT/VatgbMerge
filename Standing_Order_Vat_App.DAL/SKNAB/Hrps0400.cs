using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrps0400
    {
        public string Pystptblid { get; set; } = null!;
        public string PayStepTableDesc { get; set; } = null!;
        public short PayStepUnitOfPay { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
