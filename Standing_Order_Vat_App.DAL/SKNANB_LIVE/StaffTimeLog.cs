using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class StaffTimeLog
    {
        public string? UserId { get; set; }
        public DateTime? LoginDate { get; set; }
        public DateTime? LogInTime { get; set; }
        public DateTime? LogOutTime { get; set; }
        public string? FullName { get; set; }
        public int LogKey { get; set; }
        public string? MachineName { get; set; }
        /// <summary>
        /// time of data entry
        /// </summary>
        public DateTime? ServerTime { get; set; }
    }
}
