using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ae031000
    {
        public string EmpidI { get; set; } = null!;
        public short HoursFmla { get; set; }
        public DateTime Date1 { get; set; }
        public int DexRowId { get; set; }
    }
}
