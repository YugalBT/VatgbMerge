using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00211
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; } = null!;
        public string SvcTaskId { get; set; } = null!;
        public string SvcTaskName { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public short SvcEscalationStatus { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Endtime { get; set; }
        public int SvcTaskStartDate { get; set; }
        public int SvcTaskStartTime { get; set; }
        public int SvcTaskEndDate { get; set; }
        public int SvcTaskEndTime { get; set; }
        public string SvcCommandText { get; set; } = null!;
        public string SvcTaskComment { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
