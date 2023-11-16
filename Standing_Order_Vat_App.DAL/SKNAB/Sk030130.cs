using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sk030130
    {
        public string EmpidI { get; set; } = null!;
        public short SkillnumberI { get; set; }
        public byte PartwageI { get; set; }
        public DateTime ExpiredskillI { get; set; }
        public short PointsI { get; set; }
        public int DexRowId { get; set; }
    }
}
