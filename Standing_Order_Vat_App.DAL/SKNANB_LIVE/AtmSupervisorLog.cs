using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class AtmSupervisorLog
    {
        public DateTime? DateAndTime { get; set; }
        public string? Activity { get; set; }
        public long? Code { get; set; }
        public int? Number { get; set; }
        public string? Machine { get; set; }
        public int? AtmNumber { get; set; }
        public int LogEntry { get; set; }
    }
}
