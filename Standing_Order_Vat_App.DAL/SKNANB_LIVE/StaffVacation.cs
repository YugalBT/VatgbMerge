using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class StaffVacation
    {
        public int IdEmployee { get; set; }
        public int? NmAnnualEnt { get; set; }
        public DateTime? DtStart { get; set; }
        public DateTime? DtEnd { get; set; }
        public bool? InAppvd { get; set; }
        public bool? InNtappvd { get; set; }
        public bool? InTobeAppvd { get; set; }
        public int KeyId { get; set; }
    }
}
