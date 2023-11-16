using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hremp662
    {
        public string EmpidI { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public string CompanycodeI { get; set; } = null!;
        public string DivisioncodeI { get; set; } = null!;
        public string DepartmentcodeI { get; set; } = null!;
        public string PositioncodeI { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
