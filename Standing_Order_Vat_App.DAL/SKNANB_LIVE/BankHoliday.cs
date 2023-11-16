using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class BankHoliday
    {
        public DateTime? DtStart { get; set; }
        public DateTime? DtEnd { get; set; }
        public int KeyRow { get; set; }
    }
}
