using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrtctmp
    {
        public string CourseidI { get; set; } = null!;
        public string IclassidI { get; set; } = null!;
        public DateTime ClassstartdateI { get; set; }
        public DateTime ClassenddateI { get; set; }
        public int NumberenrolledI { get; set; }
        public int DexRowId { get; set; }
    }
}
