using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VwNationalCall
    {
        public int? EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Company { get; set; }
        public string? Division { get; set; }
        public string? Branch { get; set; }
        public string? Department { get; set; }
        public byte? InternalCall { get; set; }
        public byte? Direction { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? CallerNum { get; set; }
        public string? CallerName { get; set; }
        public string? TargetNum { get; set; }
        public string? TargetName { get; set; }
        public int? RingDurationS { get; set; }
        public int? TalkDurationMin { get; set; }
    }
}
