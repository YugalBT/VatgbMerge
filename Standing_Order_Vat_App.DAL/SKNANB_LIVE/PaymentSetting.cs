using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class PaymentSetting
    {
        public decimal LowerLimit { get; set; }
        public decimal UpperLimit { get; set; }
    }
}
