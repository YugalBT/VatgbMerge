using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa41701a
    {
        public string Pacosttrxid { get; set; } = null!;
        public short TmWipSrc { get; set; }
        public short TmCogsSrc { get; set; }
        public short TmCostContraSrc { get; set; }
        public short TmUnbilledArSrc { get; set; }
        public short TmUnbilledRevSrc { get; set; }
        public short TmArSrc { get; set; }
        public short TmPrjRevSrc { get; set; }
        public short TmOvhdSrc { get; set; }
        public short FfWipSrc { get; set; }
        public short FfCostContraSrc { get; set; }
        public short FfArSrc { get; set; }
        public short FfPrjBillingsSrc { get; set; }
        public short FfPrjExpenseSrc { get; set; }
        public short FfPrjRevenueSrc { get; set; }
        public short FfPrjLossSrc { get; set; }
        public short FfBieeSrc { get; set; }
        public short FfEiebSrc { get; set; }
        public short FfOvhdSrc { get; set; }
        public short TmPrjDeferredRevFee { get; set; }
        public short TmPrjRevFeeSrc { get; set; }
        public short TmArFeeSrc { get; set; }
        public short TmBieeFeeSrc { get; set; }
        public short TmEiebFeeSrc { get; set; }
        public short FfWipFeeSrc { get; set; }
        public short FfPrjBillingsFeeSrc { get; set; }
        public short PaffArFeeSrc { get; set; }
        public short FfPrjRevFeeSrc { get; set; }
        public short FfRetentionFeeSrc { get; set; }
        public short FfPrjDeferredRevFee { get; set; }
        public short FfBieeFeeSrc { get; set; }
        public short FfEiebFeeSrc { get; set; }
        public int DexRowId { get; set; }
    }
}
