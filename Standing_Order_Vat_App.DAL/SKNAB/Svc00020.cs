using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00020
    {
        public string UserId { get; set; } = null!;
        public short PeriodId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PeriodName { get; set; } = null!;
        public short FiscalYear { get; set; }
        public int DexRowId { get; set; }
    }
}
