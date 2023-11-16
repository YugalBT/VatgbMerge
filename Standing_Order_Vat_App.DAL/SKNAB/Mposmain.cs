using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Mposmain
    {
        public string EmpidI { get; set; } = null!;
        public string CompanycodeI { get; set; } = null!;
        public string DivisioncodeI { get; set; } = null!;
        public string DepartmentcodeI { get; set; } = null!;
        public string PositioncodeI { get; set; } = null!;
        public DateTime EffectiveDate { get; set; }
        public string SupervisorcodeI { get; set; } = null!;
        public string LoccodeI { get; set; } = null!;
        public decimal Fte { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public int DexRowId { get; set; }
    }
}
