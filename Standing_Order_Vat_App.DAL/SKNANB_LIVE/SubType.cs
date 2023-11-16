using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class SubType
    {
        public int IdMstrTyp { get; set; }
        public int IdSubTyp { get; set; }
        public string NmSubTyp { get; set; } = null!;
        public string? TxDesc { get; set; }
        public string? InNonTax { get; set; }
        public string InDelFlg { get; set; } = null!;

        public virtual MstrType IdMstrTypNavigation { get; set; } = null!;
    }
}
