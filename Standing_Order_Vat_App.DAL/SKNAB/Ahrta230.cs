using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ahrta230
    {
        public string EmpidI { get; set; } = null!;
        public string TimecodeI { get; set; } = null!;
        public short Year1 { get; set; }
        public int HoursavailableI { get; set; }
        public int DexRowId { get; set; }
    }
}
