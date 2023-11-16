using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06301
    {
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public short Status { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Strttime { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Endtime { get; set; }
        public int DexRowId { get; set; }
    }
}
